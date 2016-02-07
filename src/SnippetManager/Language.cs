// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;

namespace Pihrtsoft.Snippets
{
    /// <summary>
    /// Specifies programming language of a <see cref="Snippet"/>.
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// No language.
        /// </summary>
        None,

        /// <summary>
        /// Visual Basic language.
        /// </summary>
        VB,

        /// <summary>
        /// C# language.
        /// </summary>
        CSharp,

        /// <summary>
        /// C++ language.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = nameof(Cpp))]
        Cpp,

        /// <summary>
        /// XML language.
        /// </summary>
        Xml,

        /// <summary>
        /// XAML language.
        /// </summary>
        Xaml,

        /// <summary>
        /// JavaScript language.
        /// </summary>
        JavaScript,

        /// <summary>
        /// SQL language.
        /// </summary>
        Sql,

        /// <summary>
        /// HTML language.
        /// </summary>
        Html
    }
}
