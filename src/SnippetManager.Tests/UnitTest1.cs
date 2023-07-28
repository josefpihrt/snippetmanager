// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.IO;
using System.Linq;
using System.Text;
using Pihrtsoft.Snippets;
using Xunit;

namespace SnippetManager.Tests;

public class SnippetTests
{
    [Fact]
    public void Snippet_Deserialize()
    {
        const string filePath = @"..\..\..\Snippet.snippet";

        Snippet snippet = null;

        using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            snippet = SnippetSerializer.Deserialize(stream).FirstOrDefault();

        var settings = new SaveSettings()
        {
            IndentChars = "  ",
            OmitCodeSnippetsElement = true,
            OmitXmlDeclaration = true,
            Comment = " comment "
        };

        string oldValue = File.ReadAllText(filePath, Encoding.UTF8);

        string newValue = SnippetSerializer.CreateXml(snippet, settings);

        Assert.Equal(oldValue, newValue);
    }
}
