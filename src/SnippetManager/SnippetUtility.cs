// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using Pihrtsoft.Snippets.Comparers;

namespace Pihrtsoft.Snippets
{
    /// <summary>
    /// Provides a set of static methods that are related to <see cref="Snippet"/>.
    /// </summary>
    public static class SnippetUtility
    {
        /// <summary>
        /// Returns enumerable groups of <see cref="Snippet"/>s that have same shortcut. <see cref="SnippetComparer.Shortcut"/> is used to compare shortcuts.
        /// </summary>
        /// <param name="snippets">Collection of <see cref="Snippet"/>s.</param>
        /// <returns>Enumerable collection of <see cref="IGrouping{String, Snippet}"/> where eaech element contains shortcut and snippets with that shortcut.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="snippets"/> is <c>null</c>.</exception>
        public static IEnumerable<IGrouping<string, Snippet>> FindDuplicateShortcuts(IEnumerable<Snippet> snippets)
        {
            if (snippets == null)
                throw new ArgumentNullException(nameof(snippets));

            foreach (IGrouping<string, Snippet> grouping in snippets
                .GroupBy(f => f.Shortcut, SnippetComparer.Shortcut.GenericEqualityComparer))
            {
                if (grouping.CountExceeds(1))
                    yield return grouping;
            }
        }
    }
}
