# SnippetCode Class

[Home](../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Represents a code of the [SnippetCode.Snippet](Snippet/README.md)\.

```csharp
public class SnippetCode
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; SnippetCode

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [SnippetCode(Snippet)](-ctor/README.md) | Initializes a new instance of the [SnippetCode](./README.md) class with the specified snippet\. |

## Properties

| Property | Summary |
| -------- | ------- |
| [ContainsUnclosedDelimiter](ContainsUnclosedDelimiter/README.md) | Gets a value indicating whether snippet code contains unclosed delimiter\. |
| [Delimiter](Delimiter/README.md) | Gets the placeholder delimiter\. |
| [EndPlaceholder](EndPlaceholder/README.md) | Gets a placeholder with identifier 'end' or `null` if it is not present\. |
| [Placeholders](Placeholders/README.md) | Gets a collection of literal placeholders\. |
| [SelectedPlaceholder](SelectedPlaceholder/README.md) | Gets a placeholder with identifier 'selected' or `null` if it is not present\. |
| [Snippet](Snippet/README.md) | Gets the snippet that contains current instance\. |
| [Text](Text/README.md) | Gets the snippet code text\. |
| [TextWithDefaultValues](TextWithDefaultValues/README.md) | Gets snippet text where placeholders are replaced with matching literal's value\. System placeholders and placeholders which do not have matching literal are removed\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [RemoveAllPlaceholders()](RemoveAllPlaceholders/README.md) | Returns a new [String](https://docs.microsoft.com/en-us/dotnet/api/system.string) where all placeholders are removed\. Escaped $ characters are left intact\. |
| [RenamePlaceholder(String, String)](RenamePlaceholder/README.md) | Returns a new string in which all occurrences of a specified identifier in the current instance are replaced with another specified identifier\. |
| [ReplacePlaceholders(String, String)](ReplacePlaceholders/README.md) | Returns a new [String](https://docs.microsoft.com/en-us/dotnet/api/system.string) where all placeholders with the specified identifier are replaced\. Escaped $ characters are left intact\. |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

