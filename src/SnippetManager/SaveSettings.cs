// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Snippets
{
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

        /// <summary>
        /// Gets a value indicating whether <see cref="IndentChars"/> is equal to <see cref="DefaultIndentChars"/>.
        /// </summary>
        internal bool HasDefaultIndentChars => string.Equals(IndentChars, DefaultIndentChars, StringComparison.Ordinal);

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
    }
}
