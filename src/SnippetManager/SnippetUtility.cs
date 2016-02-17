﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using Pihrtsoft.Snippets.Comparers;

namespace Pihrtsoft.Snippets
{
    //TODO: CreateHtmlTable

    public static class SnippetUtility
    {
        public static IEnumerable<IGrouping<string, Snippet>> FindDuplicateShortcuts(IEnumerable<Snippet> snippets)
        {
            if (snippets == null)
                throw new ArgumentNullException(nameof(snippets));

            foreach (IGrouping<string, Snippet> grouping in snippets
                .Where(f => f.Shortcut.Length > 0)
                .GroupBy(f => f, SnippetComparer.Shortcut))
            {
                if (grouping.CountExceeds(1))
                    yield return grouping;
            }
        }
    }
}
