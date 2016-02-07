// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Pihrtsoft.Snippets.Comparers
{
    /// <summary>
    /// Represents a <see cref="Snippet"/> comparison operation.
    /// </summary>
    public abstract class SnippetComparer : IComparer<Snippet>, IEqualityComparer<Snippet>, IComparer, IEqualityComparer
    {
        private static readonly StringComparer _stringComparer = StringComparer.Ordinal;

        /// <summary>
        /// Gets a <see cref="SnippetComparer"/> that performs a case-sensitive ordinal <see cref="Snippet.Title"/> comparison.
        /// </summary>
        public static SnippetComparer Title => new SnippetTitleComparer();

        /// <summary>
        /// Gets a <see cref="SnippetComparer"/> that performs a case-sensitive ordinal <see cref="Snippet.Shortcut"/> comparison.
        /// </summary>
        public static SnippetComparer Shortcut => new SnippetShortcutComparer();

        /// <summary>
        /// Returns a value to compare.
        /// </summary>
        /// <param name="snippet">A snippet.</param>
        /// <returns>A string that will be used to compare two snippets.</returns>
        protected abstract string GetValue(Snippet snippet);

        /// <summary>
        /// Compares two snippets and returns an indication of their relative sort order.
        /// </summary>
        /// <param name="x">A <see cref="Snippet"/> to compare to <paramref name="y"/>.</param>
        /// <param name="y">A <see cref="Snippet"/> to compare to <paramref name="x"/>.</param>
        /// <returns>A signed integer that indicates the relative values of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public int Compare(Snippet x, Snippet y)
        {
            return _stringComparer.Compare(GetValue(x), GetValue(y));
        }

        /// <summary>
        /// Indicates whether two snippets are equal.
        /// </summary>
        /// <param name="x">A <see cref="Snippet"/> to compare to <paramref name="y"/>.</param>
        /// <param name="y">A <see cref="Snippet"/> to compare to <paramref name="x"/>.</param>
        /// <returns><c>true</c> if <paramref name="x"/> and <paramref name="y"/> refer to the same object, or <paramref name="x"/> and <paramref name="y"/> are <c>null</c>, or <paramref name="x"/> and <paramref name="y"/> are equal; otherwise, <c>false</c>.</returns>
        public bool Equals(Snippet x, Snippet y)
        {
            return _stringComparer.Equals(GetValue(x), GetValue(y));
        }

        /// <summary>
        /// Gets the hash code for the specified <see cref="Snippet"/>.
        /// </summary>
        /// <param name="obj">A snippet.</param>
        /// <returns>A 32-bit signed hash code calculated from the value of the <paramref name="obj"/>.</returns>
        public int GetHashCode(Snippet obj)
        {
            return _stringComparer.GetHashCode(GetValue(obj));
        }

        /// <summary>
        /// Compares two objects and returns an indication of their relative sort order.
        /// </summary>
        /// <param name="x">An object to compare to <paramref name="y"/>.</param>
        /// <param name="y">An object to compare to <paramref name="x"/>.</param>
        /// <returns>A signed integer that indicates the relative values of <paramref name="x"/> and <paramref name="y"/>.</returns>
        public int Compare(object x, object y)
        {
            return _stringComparer.Compare(GetValue((Snippet)x), GetValue((Snippet)y));
        }

        /// <summary>
        /// Indicates whether two objects are equal.
        /// </summary>
        /// <param name="x">An object to compare to <paramref name="y"/>.</param>
        /// <param name="y">An object to compare to <paramref name="x"/>.</param>
        /// <returns><c>true</c> if <paramref name="x"/> and <paramref name="y"/> refer to the same object, or <paramref name="x"/> and <paramref name="y"/> are both the same type of object and those objects are equal; otherwise, <c>false</c>.</returns>
        public new bool Equals(object x, object y)
        {
            return _stringComparer.Equals(GetValue((Snippet)x), GetValue((Snippet)y));
        }

        /// <summary>
        /// Gets the hash code for the specified object.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>A 32-bit signed hash code calculated from the value of the <paramref name="obj"/>.</returns>
        public int GetHashCode(object obj)
        {
            return _stringComparer.GetHashCode(GetValue((Snippet)obj));
        }
    }
}
