// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;

namespace Pihrtsoft.Snippets.Xml.Serialization
{
    /// <summary>
    /// Represents Object element in a serialized <see cref="Snippet"/>. This class cannot be inherited.
    /// </summary>
    public sealed class ObjectElement : LiteralElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectElement"/> class.
        /// </summary>
        public ObjectElement()
        {
        }

        /// <summary>
        /// Gets or sets Type element value.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
        public string Type { get; set; }
    }
}
