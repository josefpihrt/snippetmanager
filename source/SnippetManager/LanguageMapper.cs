// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Pihrtsoft.Snippets
{
    internal class LanguageMapper
    {
        private readonly Dictionary<string, Language> _mapTextToEnum;
        private readonly Dictionary<Language, string> _mapEnumToText;

        private LanguageMapper()
        {
            _mapTextToEnum = new Dictionary<string, Language>(StringComparer.OrdinalIgnoreCase)
            {
                ["VB"] = Language.VisualBasic,
                ["CSharp"] = Language.CSharp,
                ["Cpp"] = Language.Cpp,
                ["Xml"] = Language.Xml,
                ["Xaml"] = Language.Xaml,
                ["JavaScript"] = Language.JavaScript,
                ["Sql"] = Language.Sql,
                ["Html"] = Language.Html,
                ["Css"] = Language.Css
            };

            _mapEnumToText = new Dictionary<Language, string>()
            {
                [Language.VisualBasic] = "VB",
                [Language.CSharp] = "CSharp",
                [Language.Cpp] = "Cpp",
                [Language.Xml] = "Xml",
                [Language.Xaml] = "Xaml",
                [Language.JavaScript] = "JavaScript",
                [Language.Sql] = "Sql",
                [Language.Html] = "Html",
                [Language.Css] = "Css",
                [Language.None] = ""
            };
        }

        public string MapEnumToText(Language value)
        {
            return _mapEnumToText[value];
        }

        public Language MapTextToEnum(string value)
        {
            if (_mapTextToEnum.TryGetValue(value, out Language result))
                return result;

            return Language.None;
        }

        public static LanguageMapper Instance { get; } = new LanguageMapper();
    }
}
