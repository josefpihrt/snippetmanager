// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Snippets.Comparers
{
    internal class SnippetTitleComparer : SnippetComparer
    {
        protected override string GetValue(Snippet snippet)
        {
            if (snippet == null)
                throw new ArgumentNullException(nameof(snippet));

            return snippet.Title;
        }
    }
}
