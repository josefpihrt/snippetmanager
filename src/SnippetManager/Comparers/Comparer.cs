﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Snippets.Comparers;

internal static class Comparer
{
    public static StringComparer StringComparer { get; } = StringComparer.CurrentCulture;

    public static StringComparison StringComparison { get; }
}
