﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Snippets;

/// <summary>
/// Specifies a set of options that enables to modify code snippet serialization process.
/// </summary>
public sealed class SaveSettings
{
    /// <summary>
    /// Represents default indentation when serializing code snippet into xml. This field is read-only.
    /// </summary>
    internal const string DefaultIndentChars = "    ";

    /// <summary>
    /// Initializes a new instance of the <see cref="SaveSettings"/> class.
    /// </summary>
    public SaveSettings()
    {
        SetDefaultFormat = true;
        OmitDefaultDelimiter = true;
        IndentChars = DefaultIndentChars;
    }

    internal bool HasDefaultValues
    {
        get
        {
            return string.Equals(IndentChars, DefaultIndentChars, StringComparison.Ordinal)
                && !OmitXmlDeclaration;
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether default format version set is when <see cref="Snippet.FormatVersion"/> value is <c>null</c>.
    /// </summary>
    public bool SetDefaultFormat { get; set; }

    /// <summary>
    /// Gets or sets the string to use when indenting.
    /// </summary>
    public string IndentChars { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether Delimiter attribute with value equal to <see cref="Snippet.DefaultDelimiter"/> will be omitted. Default value is <c>true</c>.
    /// </summary>
    public bool OmitDefaultDelimiter { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to write an XML declaration.
    /// </summary>
    public bool OmitXmlDeclaration { get; set; }

    /// <summary>
    /// Gets or sets an XML comment that will be added to the snippet file.
    /// </summary>
    public string Comment { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to write 'CodeSnippets' XML element. This option is relevant only if a single snippet is saved to a file.
    /// </summary>
    public bool OmitCodeSnippetsElement { get; set; }
}
