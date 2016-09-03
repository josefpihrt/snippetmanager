// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.IO;
using System.Text;
using Pihrtsoft.Snippets;

namespace SnippetManagerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\Snippet.snippet";

            SnippetFile snippetFile = SnippetSerializer.DeserializeFile(filePath);

            var snippetCollection = snippetFile.Snippets;

            if (snippetCollection.Count == 1)
            {
                Snippet snippet = snippetCollection[0];

                var settings = new SaveSettings()
                {
                    IndentChars = "  ",
                    OmitCodeSnippetsElement = true,
                    OmitXmlDeclaration = true,
                    Comment = " comment "
                };

                var oldValue = File.ReadAllText(filePath, Encoding.UTF8);
                Console.WriteLine(oldValue);

                Console.WriteLine();

                var newValue = SnippetSerializer.CreateXml(snippet, settings);
                Console.WriteLine(newValue);

                Console.WriteLine();
                Console.WriteLine(string.Equals(oldValue, newValue, StringComparison.Ordinal));
            }

            Console.WriteLine("*** END ***");
            Console.ReadKey();
        }
    }
}
