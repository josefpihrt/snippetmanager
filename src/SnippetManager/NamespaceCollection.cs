﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Pihrtsoft.Snippets
{
    /// <summary>
    /// Represents the set of namespaces.
    /// </summary>
    public class NamespaceCollection
        : Collection<string>
    {
        private static readonly NamespaceComparer _sorter = new NamespaceComparer(placeSystemFirst: true);

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceCollection"/> class that is empty.
        /// </summary>
        public NamespaceCollection()
            : base(new List<string>())
        {
        }

        /// <summary>
        /// Sorts the elements in the entire <see cref="NamespaceCollection"/> using the <see cref="StringComparer.InvariantCulture"/> comparer.
        /// </summary>
        public void Sort()
        {
            Sort(_sorter);
        }

        /// <summary>
        /// Sorts the elements in the entire <see cref="NamespaceCollection"/> using the specified comparer.
        /// </summary>
        /// <param name="comparer">The <see cref="IComparer{String}"/> implementation to use when comparing elements.</param>
        public void Sort(IComparer<string> comparer)
        {
            List.Sort(comparer);
        }

        private List<string> List => (List<string>)Items;
    }
}
