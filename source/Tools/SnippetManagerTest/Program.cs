// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.IO;
using System.Linq;
using System.Text;
using Pihrtsoft.Snippets;

namespace SnippetManagerTest
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            string filePath = @"..\..\Snippet.snippet";

            Snippet snippet = null;

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                snippet = SnippetSerializer.Deserialize(stream).FirstOrDefault();

            if (snippet != null)
            {
                var settings = new SaveSettings()
                {
                    IndentChars = "  ",
                    OmitCodeSnippetsElement = true,
                    OmitXmlDeclaration = true,
                    Comment = " comment "
                };

                string oldValue = File.ReadAllText(filePath, Encoding.UTF8);
                Console.WriteLine(oldValue);

                Console.WriteLine();

                string newValue = SnippetSerializer.CreateXml(snippet, settings);
                Console.WriteLine(newValue);

                Console.WriteLine();
                Console.WriteLine(string.Equals(oldValue, newValue, StringComparison.Ordinal));
            }

            Console.WriteLine("*** END ***");
            Console.ReadKey();
        }
    }
}
