// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Xml;
using System.Xml.Serialization;

namespace Pihrtsoft.Snippets.Xml.Serialization
{
    /// <summary>
    /// Represents Code element in a serialized <see cref="Snippet"/>. This class cannot be inherited.
    /// </summary>
    public sealed class CodeElement
    {
        /// <summary>
        /// Gets or sets Delimiter attribute value.
        /// </summary>
        [XmlAttribute]
        public string Delimiter { get; set; }

        /// <summary>
        /// Gets or sets Kind attribute value.
        /// </summary>
        [XmlAttribute]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets Language attribute value.
        /// </summary>
        [XmlAttribute]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets Code element CData value.
        /// </summary>
        [XmlIgnore]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets Code element CData section.
        /// </summary>
        [XmlText]
        public XmlNode[] CodeCData
        {
            get { return new XmlNode[] { new XmlDocument().CreateCDataSection(Code) }; }
            set
            {
                if (value == null)
                    Code = string.Empty;
                else if (value.Length == 1)
                    Code = value[0].Value;
                else
                    throw new InvalidOperationException($"Invalid array length {value.Length}.");
            }
        }
    }
}
