# ValidationRule Class

[Home](../../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets.Validations](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

\
Represents the rule for a [Snippet](../../Snippet/README.md) validation\. This class is abstract\.

```csharp
public abstract class ValidationRule
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; ValidationRule

### Derived

* [AssemblyReferenceValidationRule](../AssemblyReferenceValidationRule/README.md)
* [CodeValidationRule](../CodeValidationRule/README.md)
* [DescriptionValidationRule](../DescriptionValidationRule/README.md)
* [FormatVersionValidationRule](../FormatVersionValidationRule/README.md)
* [LiteralValidationRule](../LiteralValidationRule/README.md)
* [...](#derived-all "See all derived types")

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [ValidationRule()](-ctor/README.md) | Initializes a new instance of the [ValidationRule](./README.md) class\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Validate(Snippet)](Validate/README.md) | Validates a specified snippet and returns enumerable collection of [SnippetValidationResult](../SnippetValidationResult/README.md)\. |

## Derived \(All\)

* [AssemblyReferenceValidationRule](../AssemblyReferenceValidationRule/README.md)
* [CodeValidationRule](../CodeValidationRule/README.md)
* [DescriptionValidationRule](../DescriptionValidationRule/README.md)
* [FormatVersionValidationRule](../FormatVersionValidationRule/README.md)
* [LiteralValidationRule](../LiteralValidationRule/README.md)
* &mdash;&mdash;&mdash;&mdash;&mdash;
* [NamespaceValidationRule](../NamespaceValidationRule/README.md)
* [ShortcutValidationRule](../ShortcutValidationRule/README.md)
* [SnippetTypeValidationRule](../SnippetTypeValidationRule/README.md)
* [TitleValidationRule](../TitleValidationRule/README.md)
