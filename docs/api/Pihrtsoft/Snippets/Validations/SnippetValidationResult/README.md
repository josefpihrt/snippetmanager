# SnippetValidationResult Class

[Home](../../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets.Validations](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Represents a result of the [SnippetValidationResult.Snippet](Snippet/README.md) validation\.

```csharp
public class SnippetValidationResult
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; SnippetValidationResult

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [SnippetValidationResult(Snippet, String, String, ResultImportance)](-ctor/README.md#Pihrtsoft_Snippets_Validations_SnippetValidationResult__ctor_Pihrtsoft_Snippets_Snippet_System_String_System_String_Pihrtsoft_Snippets_Validations_ResultImportance_) | Initializes a new instance of the [SnippetValidationResult](./README.md) class using the specified snippet, code, description a and importance\. |
| [SnippetValidationResult(Snippet, String, String, ResultImportance, Object)](-ctor/README.md#Pihrtsoft_Snippets_Validations_SnippetValidationResult__ctor_Pihrtsoft_Snippets_Snippet_System_String_System_String_Pihrtsoft_Snippets_Validations_ResultImportance_System_Object_) | Initializes a new instance of the [SnippetValidationResult](./README.md) class using the specified snippet, code, description, importance and content\. |

## Properties

| Property | Summary |
| -------- | ------- |
| [Code](Code/README.md) | Gets the alphanumeric code of the result\. |
| [Content](Content/README.md) | Gets the additional content of the result\. The value can be `null`\. |
| [Description](Description/README.md) | Gets the description text\. |
| [Importance](Importance/README.md) | Gets the importance level\. |
| [Snippet](Snippet/README.md) | Gets the [SnippetValidationResult.Snippet](Snippet/README.md) the is the source of the result\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

