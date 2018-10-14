# Literal Class

[Home](../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Represents a code snippet literal\.

```csharp
public class Literal : System.ICloneable
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; Literal

### Implements

* System\.[ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [Literal(String, String, String)](-ctor/README.md) | Initializes a new instance of the [Literal](./README.md) class with a specified identifier, tooltip and default value\. |

## Properties

| Property | Summary |
| -------- | ------- |
| [DefaultValue](DefaultValue/README.md) | Gets or sets literal default value\. |
| [Function](Function/README.md) | Gets or sets literal function name\. |
| [Identifier](Identifier/README.md) | Gets or sets literal identifier\. |
| [IsEditable](IsEditable/README.md) | Gets or sets a value indicating whether literal can be edited by a user when inserting a snippet into code\. |
| [ToolTip](ToolTip/README.md) | Gets or sets literal tooltip\. |
| [TypeName](TypeName/README.md) | Gets or sets the type name of the object\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Clone()](Clone/README.md) | Creates a new [Literal](./README.md) that is a deep copy of the current instance\. \(Implements [ICloneable.Clone](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable.clone)\) |
| [CreateClassNameLiteral(String, String, String)](CreateClassNameLiteral/README.md) | Create new [Literal](./README.md) with function that returns containing type name\. |
| [CreateSwitchCasesLiteral(String, String, String, String)](CreateSwitchCasesLiteral/README.md) | Create new [Literal](./README.md) with function generates switch cases\. |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

