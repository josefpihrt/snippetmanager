# LiteralComparer\.Compare Method

[Home](../../../../../README.md)

**Containing Type**: [LiteralComparer](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Compare(Literal, Literal)](#Pihrtsoft_Snippets_Comparers_LiteralComparer_Compare_Pihrtsoft_Snippets_Literal_Pihrtsoft_Snippets_Literal_) | Compares two literals and returns an indication of their relative sort order\. \(Implements [IComparer\<Literal>.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1.compare)\) |
| [Compare(Object, Object)](#Pihrtsoft_Snippets_Comparers_LiteralComparer_Compare_System_Object_System_Object_) | Compares two objects and returns an indication of their relative sort order\. \(Implements [IComparer.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icomparer.compare)\) |

## Compare\(Literal, Literal\) <a id="Pihrtsoft_Snippets_Comparers_LiteralComparer_Compare_Pihrtsoft_Snippets_Literal_Pihrtsoft_Snippets_Literal_"></a>

\
Compares two literals and returns an indication of their relative sort order\.

```csharp
public int Compare(Pihrtsoft.Snippets.Literal x, Pihrtsoft.Snippets.Literal y)
```

### Parameters

**x** &ensp; [Literal](../../../Literal/README.md)

A [Literal](../../../Literal/README.md) to compare to **y**\.

**y** &ensp; [Literal](../../../Literal/README.md)

A [Literal](../../../Literal/README.md) to compare to **x**\.

### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A signed integer that indicates the relative values of **x** and **y**\.

### Implements

* [IComparer\<Literal>.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1.compare)

## Compare\(Object, Object\) <a id="Pihrtsoft_Snippets_Comparers_LiteralComparer_Compare_System_Object_System_Object_"></a>

\
Compares two objects and returns an indication of their relative sort order\.

```csharp
public int Compare(object x, object y)
```

### Parameters

**x** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

An object to compare to **y**\.

**y** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

An object to compare to **x**\.

### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A signed integer that indicates the relative values of **x** and **y**\.

### Implements

* [IComparer.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icomparer.compare)
