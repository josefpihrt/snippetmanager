// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace Pihrtsoft.Snippets.Xml.Serialization
{
    /// <summary>
    /// Represents Snippet element in a serialized <see cref="Snippet"/>. This class cannot be inherited.
    /// </summary>
    public sealed class SnippetElement
    {
        /// <summary>
        /// Gets or sets Imports element.
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [XmlArrayItem("Import")]
        public ImportElement[] Imports { get; set; }

        /// <summary>
        /// Gets or sets References element.
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [XmlArrayItem("Reference")]
        public ReferenceElement[] References { get; set; }

        /// <summary>
        /// Gets or sets Declarations element.
        /// </summary>
        public DeclarationsElement Declarations { get; set; }

        /// <summary>
        /// Gets or sets Code element.
        /// </summary>
        public CodeElement Code { get; set; }
    }
}
