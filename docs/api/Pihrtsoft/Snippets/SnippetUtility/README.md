# SnippetUtility Class

[Home](../../../README.md) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Provides a set of static methods that are related to [Snippet](../Snippet/README.md)\.

```csharp
public static class SnippetUtility
```

## Methods

| Method | Summary |
| ------ | ------- |
| [FindDuplicateShortcuts(IEnumerable\<Snippet>)](FindDuplicateShortcuts/README.md) | Returns enumerable groups of [Snippet](../Snippet/README.md)s that have same shortcut\. [SnippetComparer.Shortcut](../Comparers/SnippetComparer/Shortcut/README.md) is used to compare shortcuts\. |
| [RemoveUnusedLiterals(Snippet)](RemoveUnusedLiterals/README.md) | Removes all literals that do not have corresponding placeholder \(placeholder with same identifier\)\. |
| [RemoveUnusedPlaceholders(Snippet)](RemoveUnusedPlaceholders/README.md) | Removes all placeholders that do not have corresponding literal \(literal with same identifier\)\. |

