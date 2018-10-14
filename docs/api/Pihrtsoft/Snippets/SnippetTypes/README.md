# SnippetTypes Enum

[Home](../../../README.md) &#x2022; [Fields](#fields)

**Namespace**: [Pihrtsoft.Snippets](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Specifies how the code snippet can be inserted into code\.

```csharp
[System.FlagsAttribute]
public enum SnippetTypes
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) &#x2192; SnippetTypes

### Attributes

* System\.[FlagsAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.flagsattribute)

## Fields

| Name | Value | Summary |
| ---- | ----- | ------- |
| None | 0 | Specifies that no snippet type is set\. |
| Expansion | 1 | Specifies that the code snippet can be inserted at the cursor\. |
| SurroundsWith | 2 | Specifies that the code snippet can be placed around a block of code\. |
| Refactoring | 4 | Specifies that the code snippet can be used during refactoring\. |

