# SnippetUtility\.FindDuplicateShortcuts\(IEnumerable\<Snippet>\) Method

[Home](../../../../README.md)

**Containing Type**: [SnippetUtility](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Returns enumerable groups of [Snippet](../../Snippet/README.md)s that have same shortcut\. [SnippetComparer.Shortcut](../../Comparers/SnippetComparer/Shortcut/README.md) is used to compare shortcuts\.

```csharp
public static System.Collections.Generic.IEnumerable<Pihrtsoft.Snippets.DuplicateShortcutInfo> FindDuplicateShortcuts(System.Collections.Generic.IEnumerable<Pihrtsoft.Snippets.Snippet> snippets)
```

### Parameters

**snippets** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Snippet](../../Snippet/README.md)>

Collection of [Snippet](../../Snippet/README.md)s\.

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[DuplicateShortcutInfo](../../DuplicateShortcutInfo/README.md)>

Enumerable collection of [DuplicateShortcutInfo](../../DuplicateShortcutInfo/README.md) where each element contains shortcut and snippets with that shortcut\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippets** is `null`\.

