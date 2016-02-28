// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Pihrtsoft.Snippets.Xml.Serialization;

namespace Pihrtsoft.Snippets
{
    /// <summary>
    /// Manages code snippet serialization and deserialization.
    /// </summary>
    public static class SnippetSerializer
    {
        /// <summary>
        /// Represents code snippet default xml namespace. This field is a constant.
        /// </summary>
        public const string DefaultNamespace = "http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet";

        private static XmlSerializer _codeSnippetsElementXmlSerializer;
        private static XmlSerializer _codeSnippetElementXmlSerializer;
        private static XmlWriterSettings _xmlWriterSettings;
        private static XmlReaderSettings _xmlReaderSettings;
        private static XmlSerializerNamespaces _namespaces;
        private static readonly Encoding _utf8Encoding = Encoding.UTF8;

        /// <summary>
        /// Returns enumerable collection of <see cref="Snippet"/> deserialized from snippet files in a specified directory.
        /// </summary>
        /// <param name="directoryPath">The absolute or relative path to the directory to search.</param>
        /// <param name="searchOption">A <see cref="SearchOption"/> value that specifies whether the search should include all subdirectories or only current directory.</param>
        /// <returns>An enumerable collection <see cref="Snippet"/> being deserialized.</returns>
        public static IEnumerable<Snippet> Deserialize(string directoryPath, SearchOption searchOption = SearchOption.TopDirectoryOnly)
        {
            foreach (SnippetFile snippetFile in DeserializeFiles(directoryPath, searchOption))
            {
                for (int i = 0; i < snippetFile.Snippets.Count; i++)
                    yield return snippetFile.Snippets[i];
            }
        }

        /// <summary>
        /// Returns enumerable collection of <see cref="SnippetFile"/> deserialized from snippet files in a specified directory.
        /// </summary>
        /// <param name="directoryPath">The absolute or relative path to the directory to search.</param>
        /// <param name="searchOption">A <see cref="SearchOption"/> value that specifies whether the search should include all subdirectories or only current directory.</param>
        /// <returns>An enumerable collection <see cref="SnippetFile"/> being deserialized.</returns>
        public static IEnumerable<SnippetFile> DeserializeFiles(string directoryPath, SearchOption searchOption = SearchOption.TopDirectoryOnly)
        {
            foreach (string filePath in SnippetFileSearcher.EnumerateSnippetFiles(directoryPath, searchOption))
                yield return DeserializeFile(filePath);
        }

        /// <summary>
        /// Returns enumerable collection of <see cref="Snippet"/> deserialized from a specified snippet file.
        /// </summary>
        /// <param name="filePath">The absolute or relative path to the file.</param>
        /// <returns>An enumerable collection <see cref="Snippet"/> being deserialized.</returns>
        public static SnippetFile DeserializeFile(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var file = new SnippetFile(filePath);
                int index = 0;

                Debug.WriteLine($"deserializing snippet file '{filePath}'");

                foreach (Snippet snippet in Deserialize(stream))
                {
                    snippet.FilePath = filePath;
                    snippet.Index = index;
                    file.Snippets.Add(snippet);
                    index++;
                }

                return file;
            }
        }

        /// <summary>
        /// Returns enumerable collection of <see cref="Snippet"/> contained by a specified <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream">The <see cref="Stream"/> that contains snippets to deserialize.</param>
        /// <returns>Enumerable collection of snippets being deserialized.</returns>
        private static IEnumerable<Snippet> Deserialize(Stream stream)
        {
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            using (XmlReader xmlReader = XmlReader.Create(stream, XmlReaderSettings))
            {
                while (xmlReader.Read() && xmlReader.NodeType != XmlNodeType.Element)
                {
                }

                switch (xmlReader.Name)
                {
                    case "CodeSnippet":
                        {
                            CodeSnippetElement element = Deserialize<CodeSnippetElement>(xmlReader, CodeSnippetElementXmlSerializer);

                            yield return SnippetMapper.MapFromElement(element);

                            break;
                        }
                    case "CodeSnippets":
                        {
                            CodeSnippetsElement element = Deserialize<CodeSnippetsElement>(xmlReader, CodeSnippetsElementXmlSerializer);

                            for (int i = 0; i < element.Snippets.Length; i++)
                                yield return SnippetMapper.MapFromElement(element.Snippets[i]);

                            break;
                        }
                };
            }
        }

        private static T Deserialize<T>(XmlReader xmlReader, XmlSerializer xmlSerializer)
        {
#if DEBUG
            try
            {
#endif
                return (T)xmlSerializer.Deserialize(xmlReader);
#if DEBUG
            }
            catch (InvalidOperationException ex)
            {
                Debug.WriteLine(ex.GetBaseException());
                throw;
            }
#endif
        }

        /// <summary>
        /// Serializes the specified <see cref="Snippet"/> the the specified snippet file.
        /// </summary>
        /// <param name="filePath">The absolute or relative path to the file.</param>
        /// <param name="snippet">A <see cref="Snippet"/> to be serialized.</param>
        public static void Serialize(string filePath, Snippet snippet)
        {
            Serialize(filePath, snippet, new SaveSettings());
        }

        /// <summary>
        /// Serializes the specified <see cref="Snippet"/> the the specified snippet file, optionally using <see cref="SaveSettings"/> to modify serialization process.
        /// </summary>
        /// <param name="filePath">The absolute or relative path to the file.</param>
        /// <param name="snippet">A <see cref="Snippet"/> to be serialized.</param>
        /// <param name="settings">A <see cref="SaveSettings"/> that modify serialization process.</param>
        public static void Serialize(string filePath, Snippet snippet, SaveSettings settings)
        {
            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));

            if (snippet == null)
                throw new ArgumentNullException(nameof(snippet));

            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            using (var stream = new FileStream(filePath, FileMode.CreateNew, FileAccess.Write, FileShare.None))
                Serialize(stream, snippet, settings);
        }

        /// <summary>
        /// Serializes the specified <see cref="Snippet"/> the the specified <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream">The stream to output this <see cref="Snippet"/> to.</param>
        /// <param name="snippet">A <see cref="Snippet"/> to be serialized.</param>
        public static void Serialize(Stream stream, Snippet snippet)
        {
            Serialize(stream, snippet, new SaveSettings());
        }

        /// <summary>
        /// Serializes the specified <see cref="Snippet"/> the the specified <see cref="Stream"/>, optionally using <see cref="SaveSettings"/> to modify serialization process.
        /// </summary>
        /// <param name="stream">The stream to output this <see cref="Snippet"/> to.</param>
        /// <param name="snippet">A <see cref="Snippet"/> to be serialized.</param>
        /// <param name="settings">A <see cref="SaveSettings"/> that modify serialization process.</param>
        public static void Serialize(Stream stream, Snippet snippet, SaveSettings settings)
        {
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            if (snippet == null)
                throw new ArgumentNullException(nameof(snippet));

            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            Serialize(stream, SnippetMapper.MapToElement(snippet, settings).ToArray(), settings);
        }

        /// <summary>
        /// Serializes enumerable collection of <see cref="Snippet"/> to the specified snippet file.
        /// </summary>
        /// <param name="filePath">The absolute or relative path to the file.</param>
        /// <param name="snippets">Enumerable collection of <see cref="Snippet"/> to be serialized.</param>
        public static void Serialize(string filePath, IEnumerable<Snippet> snippets)
        {
            Serialize(filePath, snippets, new SaveSettings());
        }

        /// <summary>
        /// Serializes enumerable collection of <see cref="Snippet"/> to the specified snippet file, optionally using <see cref="SaveSettings"/> to modify serialization process.
        /// </summary>
        /// <param name="filePath">The absolute or relative path to the file.</param>
        /// <param name="snippets">Enumerable collection of <see cref="Snippet"/> to be serialized.</param>
        /// <param name="settings">A <see cref="SaveSettings"/> that modify serialization process.</param>
        public static void Serialize(string filePath, IEnumerable<Snippet> snippets, SaveSettings settings)
        {
            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));

            if (snippets == null)
                throw new ArgumentNullException(nameof(snippets));

            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            using (var stream = new FileStream(filePath, FileMode.CreateNew, FileAccess.Write, FileShare.None))
                Serialize(stream, snippets, settings);
        }

        /// <summary>
        /// Serializes the specified <see cref="SnippetFile"/> to the file.
        /// </summary>
        /// <param name="snippetFile">A snippet file to be serialized.</param>
        /// <exception cref="ArgumentNullException"><paramref name="snippetFile"/> is <c>null</c>.</exception>
        public static void Serialize(SnippetFile snippetFile)
        {
            if (snippetFile == null)
                throw new ArgumentNullException(nameof(snippetFile));

            Serialize(snippetFile.FullName, snippetFile.Snippets, new SaveSettings());
        }

        /// <summary>
        /// Serializes the specified <see cref="SnippetFile"/> to the file, optionally using <see cref="SaveSettings"/> to modify serialization process.
        /// </summary>
        /// <param name="snippetFile">A snippet file to be serialized.</param>
        /// <param name="settings">A <see cref="SaveSettings"/> that modify serialization process.</param>
        /// <exception cref="ArgumentNullException"><paramref name="snippetFile"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="settings"/> is <c>null</c>.</exception>
        public static void Serialize(SnippetFile snippetFile, SaveSettings settings)
        {
            if (snippetFile == null)
                throw new ArgumentNullException(nameof(snippetFile));

            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            Serialize(snippetFile.FullName, snippetFile.Snippets, settings);
        }

        /// <summary>
        /// Serializes enumerable collection of <see cref="Snippet"/> to the specified <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream">The stream to output this <see cref="Snippet"/> to.</param>
        /// <param name="snippets">Enumerable collection of <see cref="Snippet"/> to be serialized.</param>
        public static void Serialize(Stream stream, IEnumerable<Snippet> snippets)
        {
            Serialize(stream, snippets, new SaveSettings());
        }

        /// <summary>
        /// Serializes enumerable collection of <see cref="Snippet"/> to the specified <see cref="Stream"/>, optionally using <see cref="SaveSettings"/> to modify serialization process.
        /// </summary>
        /// <param name="stream">The stream to output this <see cref="Snippet"/> to.</param>
        /// <param name="snippets">Enumerable collection of <see cref="Snippet"/> to be serialized.</param>
        /// <param name="settings">A <see cref="SaveSettings"/> that modify serialization process.</param>
        public static void Serialize(Stream stream, IEnumerable<Snippet> snippets, SaveSettings settings)
        {
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            if (snippets == null)
                throw new ArgumentNullException(nameof(snippets));

            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            Serialize(stream, SnippetMapper.MapToElement(snippets, settings).ToArray(), settings);
        }

        /// <summary>
        /// Serializes a specified <see cref="Snippet"/> to xml text.
        /// </summary>
        /// <param name="snippet">A <see cref="Snippet"/> to be serialized.</param>
        /// <returns>xml text that represents a specified <see cref="Snippet"/>.</returns>
        public static string CreateXml(Snippet snippet)
        {
            return CreateXml(snippet, new SaveSettings());
        }

        /// <summary>
        /// Serializes a specified <see cref="Snippet"/> to xml text, optionally using <see cref="SaveSettings"/> to modify serialization process.
        /// </summary>
        /// <param name="snippet">A <see cref="Snippet"/> to be serialized.</param>
        /// <param name="settings">A <see cref="SaveSettings"/> that modify serialization process.</param>
        /// <returns>xml text that represents a specified <see cref="Snippet"/>.</returns>
        public static string CreateXml(Snippet snippet, SaveSettings settings)
        {
            if (snippet == null)
                throw new ArgumentNullException(nameof(snippet));

            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            using (var stream = new MemoryStream())
            {
                Serialize(stream, SnippetMapper.MapToElement(snippet, settings).ToArray(), settings);

                return _utf8Encoding.GetString(stream.ToArray());
            }
        }

        private static void Serialize(Stream stream, CodeSnippetElement[] elements, SaveSettings settings)
        {
            XmlWriterSettings xmlWriterSettings = GetXmlWriterSettings(settings, canOmitXmlDeclaration: elements.Length == 1);

            using (XmlWriter xmlWriter = XmlWriter.Create(stream, xmlWriterSettings))
            {
                xmlWriter.WriteStartDocument();

                if (!string.IsNullOrEmpty(settings.Comment))
                    xmlWriter.WriteComment(settings.Comment);

                if (xmlWriterSettings.OmitXmlDeclaration)
                    CodeSnippetElementXmlSerializer.Serialize(xmlWriter, elements[0], Namespaces);
                else
                    CodeSnippetsElementXmlSerializer.Serialize(xmlWriter, new CodeSnippetsElement() { Snippets = elements }, Namespaces);
            }
        }

        private static XmlWriterSettings GetXmlWriterSettings(SaveSettings settings, bool canOmitXmlDeclaration)
        {
            XmlWriterSettings xmlWriterSettings = XmlWriterSettings;
            if (!settings.HasDefaultIndentChars || (canOmitXmlDeclaration && settings.OmitXmlDeclaration))
            {
                xmlWriterSettings = CreateXmlWriterSettings();
                xmlWriterSettings.IndentChars = settings.IndentChars;
                xmlWriterSettings.OmitXmlDeclaration = settings.OmitXmlDeclaration;
            }

            return xmlWriterSettings;
        }

        private static XmlWriterSettings CreateXmlWriterSettings()
        {
            return new XmlWriterSettings()
            {
                IndentChars = "    ",
                Indent = true
            };
        }

        private static XmlSerializer CodeSnippetsElementXmlSerializer
        {
            get
            {
                if (_codeSnippetsElementXmlSerializer == null)
                    _codeSnippetsElementXmlSerializer = new XmlSerializer(typeof(CodeSnippetsElement), DefaultNamespace);

                return _codeSnippetsElementXmlSerializer;
            }
        }

        private static XmlSerializer CodeSnippetElementXmlSerializer
        {
            get
            {
                if (_codeSnippetElementXmlSerializer == null)
                    _codeSnippetElementXmlSerializer = new XmlSerializer(typeof(CodeSnippetElement), DefaultNamespace);

                return _codeSnippetElementXmlSerializer;
            }
        }

        private static XmlWriterSettings XmlWriterSettings
        {
            get
            {
                if (_xmlWriterSettings == null)
                    _xmlWriterSettings = CreateXmlWriterSettings();

                return _xmlWriterSettings;
            }
        }

        private static XmlReaderSettings XmlReaderSettings
        {
            get
            {
                if (_xmlReaderSettings == null)
                {
                    _xmlReaderSettings = new XmlReaderSettings()
                    {
                        CloseInput = false
                    };
                }

                return _xmlReaderSettings;
            }
        }

        private static XmlSerializerNamespaces Namespaces
        {
            get
            {
                if (_namespaces == null)
                {
                    _namespaces = new XmlSerializerNamespaces();
                    _namespaces.Add("", DefaultNamespace);
                }

                return _namespaces;
            }
        }
    }
}
