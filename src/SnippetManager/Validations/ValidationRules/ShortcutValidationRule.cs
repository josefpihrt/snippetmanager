﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Pihrtsoft.Snippets.Validations;

/// <summary>
/// Represents the validation rule for the snippet shortcut.
/// </summary>
public class ShortcutValidationRule : ValidationRule
{
    /// <summary>
    /// Validates a shortcut of the specified <see cref="Snippet"/>.
    /// </summary>
    /// <param name="snippet">A snippet to be validated.</param>
    /// <returns>Enumerable collection of validation results.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="snippet"/> is <c>null</c>.</exception>
    public override IEnumerable<SnippetValidationResult> Validate(Snippet snippet)
    {
        if (snippet is null)
            throw new ArgumentNullException(nameof(snippet));

        return Validate();

        IEnumerable<SnippetValidationResult> Validate()
        {
            if (string.IsNullOrEmpty(snippet.Shortcut))
            {
                yield return new SnippetValidationResult(
                    snippet,
                    ErrorCode.MissingShortcut,
                    "Snippet shortcut is missing.",
                    ResultImportance.Error);
            }

            if (!ValidationHelper.IsValidShortcut(snippet.Shortcut))
            {
                yield return new SnippetValidationResult(
                    snippet,
                    ErrorCode.InvalidShortcut,
                    "Snippet shortcut is invalid.",
                    ResultImportance.Error);
            }
        }
    }
}
