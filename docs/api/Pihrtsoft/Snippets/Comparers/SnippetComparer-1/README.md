# SnippetComparer\<T> Class

[Home](../../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets.Comparers](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

\
Represents a [Snippet](../../Snippet/README.md) comparison operation\.

```csharp
public abstract class SnippetComparer<T> : Pihrtsoft.Snippets.Comparers.SnippetComparer
```

### Type Parameters

**T**

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [SnippetComparer](../SnippetComparer/README.md) &#x2192; SnippetComparer\<T>

### Implements

* [IComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icomparer)
* [IComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1)\<[Snippet](../../Snippet/README.md)>
* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer)
* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1)\<[Snippet](../../Snippet/README.md)>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [SnippetComparer()](-ctor/README.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [Compare(Object, Object)](Compare/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_1_Compare_System_Object_System_Object_) | Compares two objects and returns an indication of their relative sort order\. \(Overrides [SnippetComparer.Compare](../SnippetComparer/Compare/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_Compare_System_Object_System_Object_)\) |
| [Compare(Snippet, Snippet)](Compare/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_1_Compare_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_) | Compares two snippets and returns an indication of their relative sort order\. \(Overrides [SnippetComparer.Compare](../SnippetComparer/Compare/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_Compare_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Equals(Object, Object)](Equals/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_1_Equals_System_Object_System_Object_) | Indicates whether two objects are equal\. \(Overrides [SnippetComparer.Equals](../SnippetComparer/Equals/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_Equals_System_Object_System_Object_)\) |
| [Equals(Snippet, Snippet)](Equals/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_1_Equals_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_) | Indicates whether two snippets are equal\. \(Overrides [SnippetComparer.Equals](../SnippetComparer/Equals/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_Equals_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode(Object)](GetHashCode/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_1_GetHashCode_System_Object_) | Gets the hash code for the specified object\. \(Overrides [SnippetComparer.GetHashCode](../SnippetComparer/GetHashCode/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_GetHashCode_System_Object_)\) |
| [GetHashCode(Snippet)](GetHashCode/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_1_GetHashCode_Pihrtsoft_Snippets_Snippet_) | Gets the hash code for the specified [Snippet](../../Snippet/README.md)\. \(Overrides [SnippetComparer.GetHashCode](../SnippetComparer/GetHashCode/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_GetHashCode_Pihrtsoft_Snippets_Snippet_)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetValue(Snippet)](GetValue/README.md) | Returns a value to compare\. |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

