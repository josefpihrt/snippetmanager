// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace Pihrtsoft.Snippets.Xml.Serialization
{
    /// <summary>
    /// Represents Declarations element in a serialized <see cref="Snippet"/>. This class cannot be inherited.
    /// </summary>
    public sealed class DeclarationsElement
    {
        /// <summary>
        /// Gets or sets array of Literal elements.
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [XmlElement("Literal")]
        public LiteralElement[] Literals { get; set; }

        /// <summary>
        /// Gets or sets array of Object elements.
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [XmlElement("Object")]
        public ObjectElement[] Objects { get; set; }
    }
}
