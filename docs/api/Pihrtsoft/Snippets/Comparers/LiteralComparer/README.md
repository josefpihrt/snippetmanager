# LiteralComparer Class

[Home](../../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets.Comparers](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Represents a [Literal](../../Literal/README.md) comparison operation\.

```csharp
public abstract class LiteralComparer : System.Collections.IComparer,
    System.Collections.IEqualityComparer,
    System.Collections.Generic.IComparer<Pihrtsoft.Snippets.Literal>,
    System.Collections.Generic.IEqualityComparer<Pihrtsoft.Snippets.Literal>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; LiteralComparer

### Implements

* System\.Collections\.[IComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icomparer)
* System\.Collections\.[IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer)
* System\.Collections\.Generic\.[IComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1)\<[Literal](../../Literal/README.md)>
* System\.Collections\.Generic\.[IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1)\<[Literal](../../Literal/README.md)>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [LiteralComparer()](-ctor/README.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Identifier](Identifier/README.md) | Gets a [LiteralComparer](./README.md) that performs a case\-sensitive ordinal [Literal.Identifier](../../Literal/Identifier/README.md) comparison\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Compare(Literal, Literal)](Compare/README.md#Pihrtsoft_Snippets_Comparers_LiteralComparer_Compare_Pihrtsoft_Snippets_Literal_Pihrtsoft_Snippets_Literal_) | Compares two literals and returns an indication of their relative sort order\. \(Implements [IComparer\<Literal>.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1.compare)\) |
| [Compare(Object, Object)](Compare/README.md#Pihrtsoft_Snippets_Comparers_LiteralComparer_Compare_System_Object_System_Object_) | Compares two objects and returns an indication of their relative sort order\. \(Implements [IComparer.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icomparer.compare)\) |
| [Equals(Literal, Literal)](Equals/README.md#Pihrtsoft_Snippets_Comparers_LiteralComparer_Equals_Pihrtsoft_Snippets_Literal_Pihrtsoft_Snippets_Literal_) | Indicates whether two literals are equal\. \(Implements [IEqualityComparer\<Literal>.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1.equals)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Equals(Object, Object)](Equals/README.md#Pihrtsoft_Snippets_Comparers_LiteralComparer_Equals_System_Object_System_Object_) | Indicates whether two objects are equal\. \(Implements [IEqualityComparer.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer.equals)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode(Literal)](GetHashCode/README.md#Pihrtsoft_Snippets_Comparers_LiteralComparer_GetHashCode_Pihrtsoft_Snippets_Literal_) | Gets the hash code for the specified [Literal](../../Literal/README.md)\. \(Implements [IEqualityComparer\<Literal>.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1.gethashcode)\) |
| [GetHashCode(Object)](GetHashCode/README.md#Pihrtsoft_Snippets_Comparers_LiteralComparer_GetHashCode_System_Object_) | Gets the hash code for the specified literal\. \(Implements [IEqualityComparer.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer.gethashcode)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetValue(Literal)](GetValue/README.md) | Returns a value to compare\. |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

