# LiteralCollection\.Sort Method

[Home](../../../../README.md)

**Containing Type**: [LiteralCollection](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Sort()](#Pihrtsoft_Snippets_LiteralCollection_Sort) | Sorts the elements in the entire [LiteralCollection](../README.md) using the [LiteralComparer.Identifier](../../Comparers/LiteralComparer/Identifier/README.md) comparer\. |
| [Sort(IComparer\<Literal>)](#Pihrtsoft_Snippets_LiteralCollection_Sort_System_Collections_Generic_IComparer_Pihrtsoft_Snippets_Literal__) | Sorts the elements in the entire [LiteralCollection](../README.md) using the specified comparer\. |

## Sort\(\) <a id="Pihrtsoft_Snippets_LiteralCollection_Sort"></a>

\
Sorts the elements in the entire [LiteralCollection](../README.md) using the [LiteralComparer.Identifier](../../Comparers/LiteralComparer/Identifier/README.md) comparer\.

```csharp
public void Sort()
```

## Sort\(IComparer\<Literal>\) <a id="Pihrtsoft_Snippets_LiteralCollection_Sort_System_Collections_Generic_IComparer_Pihrtsoft_Snippets_Literal__"></a>

\
Sorts the elements in the entire [LiteralCollection](../README.md) using the specified comparer\.

```csharp
public void Sort(System.Collections.Generic.IComparer<Pihrtsoft.Snippets.Literal> comparer)
```

### Parameters

**comparer** &ensp; [IComparer](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1)\<[Literal](../../Literal/README.md)>

The [IComparer\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1) implementation to use when comparing elements\.