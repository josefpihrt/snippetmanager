// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Snippets
{
    internal static class SnippetUtility
    {
        public static bool IsValidVersion(Version version)
        {
            if (version == null
                || version.Major == -1
                || version.Minor == -1
                || version.Build == -1
                || version.Revision != -1)
            {
                return false;
            }

            return true;
        }
    }
}
