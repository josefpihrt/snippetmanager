// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Pihrtsoft.Snippets.Validations
{
    /// <summary>
    /// Represents a validator that validates <see cref="Snippet"/>.
    /// </summary>
    public class SnippetValidator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetValidator"/> class.
        /// </summary>
        protected SnippetValidator()
        {
            ValidationRules = new Collection<ValidationRule>();
        }

        /// <summary>
        /// Validates the specified <see cref="Snippet"/> according the the code snippet schema.
        /// </summary>
        /// <param name="snippet">A <see cref="Snippet"/> that is being validated.</param>
        /// <returns>A <see cref="SnippetValidationContext"/> that stores data about the validation.</returns>
        public IEnumerable<SnippetValidationResult> Validate(Snippet snippet)
        {
            if (snippet == null)
                throw new ArgumentNullException(nameof(snippet));

            var context = new SnippetValidationContext(snippet);

            foreach (SnippetValidationResult result in Validate(context))
                yield return result;
        }

        /// <summary>
        /// Validates the specified <see cref="Snippet"/> according the the code snippet schema.
        /// </summary>
        /// <param name="context">A <see cref="SnippetValidationContext"/> that stores data about the validation.</param>
        protected virtual IEnumerable<SnippetValidationResult> Validate(SnippetValidationContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            foreach (ValidationRule rule in ValidationRules)
            {
                foreach (SnippetValidationResult result in rule.Validate(context.Snippet))
                    yield return result;
            }
        }

        /// <summary>
        /// Creates <see cref="SnippetValidator"/> that contains validation rules defines in <see cref="Validations"/> namespace.
        /// </summary>
        /// <returns><see cref="SnippetValidator"/> with predefined validation rules.</returns>
        public static SnippetValidator CreateDefaultValidator()
        {
            var validator = new SnippetValidator();

            validator.ValidationRules.AddRange(ValidationRule.PredefinedRules);

            return validator;
        }

        /// <summary>
        /// Gets a collection of validation rules.
        /// </summary>
        public Collection<ValidationRule> ValidationRules { get; }
    }
}
