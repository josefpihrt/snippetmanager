// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Snippets
{
    /// <summary>
    /// Specifies the location at which a code snippet can be inserted.
    /// </summary>
    public enum ContextKind
    {
        /// <summary>
        /// Specifies that the code snippet has no context defined.
        /// </summary>
        None,

        /// <summary>
        /// Specifies that the code snippet can be inserted anywhere.
        /// </summary>
        Any,

        /// <summary>
        /// Specifies that the code snippet is a full code file.
        /// </summary>
        File,

        /// <summary>
        /// Specifies that the code snippet is a method body.
        /// </summary>
        MethodBody,

        /// <summary>
        /// Specifies that the code snippet is a method.
        /// </summary>
        MethodDeclaration,

        /// <summary>
        /// Specifies that the code snippet can be inserted anywhere.
        /// </summary>
        TypeDeclaration,
    }
}
