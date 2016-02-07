// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace Pihrtsoft.Snippets.Xml.Serialization
{
    /// <summary>
    /// Represents CodeSnippets element in a serialized <see cref="Snippet"/>. This class cannot be inherited.
    /// </summary>
    [XmlRoot("CodeSnippets")]
    public sealed class CodeSnippetsElement
    {
        /// <summary>
        /// Gets or sets array of CodeSnippet elements.
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [XmlElement("CodeSnippet")]
        public CodeSnippetElement[] Snippets { get; set; }
    }
}
