#### 1.3.0 (2017-01-09)

* Add support for .NET Standard 1.3
* Add support for Portable Class Library

#### 1.2.2 (2016-10-24)

* Add method SnippetUtility.RemoveUnusedLiterals.
* Add method SnippetUtility.RemoveUnusedPlaceholders.
* Add DebuggerDisplayAttribute.

#### 1.2.0 (2016-09-12)

* Add method SnippetCode.ReplacePlaceholders(string, string).
* Add method LiteralCollection.Remove(string).
* Update SnippetUtility.FindDuplicateShortcuts method so it reflects possible alternative shortcuts.

#### 1.1.0 (2016-09-03)

* Add support for xml element "AlternativeShortcuts".
* Fix bug in SnippetSerializer.CreateXml method - remove BOM from returned string.

#### 1.0.0 (2016-04-30)

* Add "LiteralRenamer" API which supports renaming of snippet literal including its occurrences in the code.
* Rename Language.VB to Language.VisualBasic.
* Rename Language.Cpp to Language.CPlusPlus.

#### 0.9.1 (2016-02-07)

* Initial release.
