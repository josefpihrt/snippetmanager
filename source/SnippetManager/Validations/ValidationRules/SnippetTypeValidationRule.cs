// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Pihrtsoft.Snippets.Validations
{
    /// <summary>
    /// Represents a validation rule for the snippet formar version.
    /// </summary>
    public class SnippetTypeValidationRule : ValidationRule
    {
        /// <summary>
        /// Validates a format version of the specified <see cref="Snippet"/>.
        /// </summary>
        /// <param name="snippet">A snippet to be validated.</param>
        /// <returns>Enumerable collection of validation results.</returns>
        public override IEnumerable<SnippetValidationResult> Validate(Snippet snippet)
        {
            if (snippet == null)
                throw new ArgumentNullException(nameof(snippet));

            if (snippet.SnippetTypes == SnippetTypes.None)
            {
                yield return new SnippetValidationResult(
                    snippet,
                    ErrorCode.MissingSnippetType,
                    "Snippet type is missing.",
                    ResultImportance.Information);
            }
        }
    }
}
