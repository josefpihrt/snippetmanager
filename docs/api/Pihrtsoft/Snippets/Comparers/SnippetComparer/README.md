# SnippetComparer Class

[Home](../../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets.Comparers](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Represents a [Snippet](../../Snippet/README.md) comparison operation\.

```csharp
public abstract class SnippetComparer : System.Collections.IComparer,
    System.Collections.IEqualityComparer,
    System.Collections.Generic.IComparer<Pihrtsoft.Snippets.Snippet>,
    System.Collections.Generic.IEqualityComparer<Pihrtsoft.Snippets.Snippet>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; SnippetComparer

### Derived

* Pihrtsoft\.Snippets\.Comparers\.[SnippetComparer\<T>](../SnippetComparer-1/README.md)

### Implements

* System\.Collections\.[IComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icomparer)
* System\.Collections\.[IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer)
* System\.Collections\.Generic\.[IComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1)\<[Snippet](../../Snippet/README.md)>
* System\.Collections\.Generic\.[IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1)\<[Snippet](../../Snippet/README.md)>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [SnippetComparer()](-ctor/README.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Shortcut](Shortcut/README.md) | Gets a [SnippetComparer\<T>](../SnippetComparer-1/README.md) that performs a case\-sensitive ordinal [Snippet.Shortcut](../../Snippet/Shortcut/README.md) comparison\. |
| [Title](Title/README.md) | Gets a [SnippetComparer\<T>](../SnippetComparer-1/README.md) that performs a case\-sensitive ordinal [Snippet.Title](../../Snippet/Title/README.md) comparison\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Compare(Object, Object)](Compare/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_Compare_System_Object_System_Object_) | Compares two objects and returns an indication of their relative sort order\. \(Implements [IComparer.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icomparer.compare)\) |
| [Compare(Snippet, Snippet)](Compare/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_Compare_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_) | Compares two snippets and returns an indication of their relative sort order\. \(Implements [IComparer\<Snippet>.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1.compare)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Equals(Object, Object)](Equals/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_Equals_System_Object_System_Object_) | Indicates whether two objects are equal\. \(Implements [IEqualityComparer.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer.equals)\) |
| [Equals(Snippet, Snippet)](Equals/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_Equals_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_) | Indicates whether two snippets are equal\. \(Implements [IEqualityComparer\<Snippet>.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1.equals)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode(Object)](GetHashCode/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_GetHashCode_System_Object_) | Gets the hash code for the specified object\. \(Implements [IEqualityComparer.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer.gethashcode)\) |
| [GetHashCode(Snippet)](GetHashCode/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_GetHashCode_Pihrtsoft_Snippets_Snippet_) | Gets the hash code for the specified [Snippet](../../Snippet/README.md)\. \(Implements [IEqualityComparer\<Snippet>.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1.gethashcode)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

