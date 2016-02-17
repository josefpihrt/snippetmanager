// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Snippets
{
    /// <summary>
    /// Represents a code snippet literal.
    /// </summary>
    public class Literal : ICloneable
    {
        private string _identifier;
        private string _defaultValue;

        internal static readonly StringComparer IdentifierComparer = StringComparer.Ordinal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Literal"/> class with a specified identifier, tooltip and default value.
        /// </summary>
        /// <param name="identifier">The <see cref="Literal"/> identifier.</param>
        /// <param name="toolTip">The <see cref="Literal"/> description.</param>
        /// <param name="defaultValue">The <see cref="Literal"/>default value.</param>
        /// <exception cref="ArgumentNullException"><paramref name="identifier"/> is <c>null</c>.</exception>
        public Literal(string identifier, string toolTip = null, string defaultValue = "")
        {
            if (identifier == null)
                throw new ArgumentNullException(nameof(identifier));

            Identifier = identifier;
            ToolTip = toolTip;
            DefaultValue = defaultValue;
            IsEditable = true;
        }

        /// <summary>
        /// Creates a new <see cref="Literal"/> that is a deep copy of the current instance.
        /// </summary>
        /// <returns>A new <see cref="Literal"/> that is a deep copy of the current instance</returns>
        public object Clone()
        {
            var clone = new Literal(Identifier);

            clone.DefaultValue = DefaultValue;
            clone.Function = Function;
            clone.ToolTip = ToolTip;
            clone.TypeName = TypeName;
            clone.IsEditable = IsEditable;

            return clone;
        }

        /// <summary>
        /// Gets or sets a value indicating whether literal can be edited by a user when inserting a snippet into code.
        /// </summary>
        public bool IsEditable { get; set; }

        /// <summary>
        /// Gets or sets literal identifier.
        /// </summary>
        public string Identifier
        {
            get { return _identifier; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));

                _identifier = value;
            }
        }

        /// <summary>
        /// Gets or sets literal tooltip.
        /// </summary>
        public string ToolTip { get; set; }

        /// <summary>
        /// Gets or sets literal default value.
        /// </summary>
        public string DefaultValue
        {
            get { return _defaultValue; }
            set { _defaultValue = value ?? string.Empty; }
        }

        /// <summary>
        /// Gets or sets literal function name.
        /// </summary>
        public string Function { get; set; }

        /// <summary>
        /// Gets or sets the type name of the object.
        /// </summary>
        public string TypeName { get; set; }
    }
}
