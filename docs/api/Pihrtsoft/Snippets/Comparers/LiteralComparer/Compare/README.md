# LiteralComparer\.Compare Method

[Home](../../../../../README.md)

**Containing Type**: Pihrtsoft\.Snippets\.Comparers\.[LiteralComparer](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Compare(Literal, Literal)](#Pihrtsoft_Snippets_Comparers_LiteralComparer_Compare_Pihrtsoft_Snippets_Literal_Pihrtsoft_Snippets_Literal_) | Compares two literals and returns an indication of their relative sort order\. \(Implements [IComparer\<Literal>.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1.compare)\) |
| [Compare(Object, Object)](#Pihrtsoft_Snippets_Comparers_LiteralComparer_Compare_System_Object_System_Object_) | Compares two objects and returns an indication of their relative sort order\. \(Implements [IComparer.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icomparer.compare)\) |

## Compare\(Literal, Literal\) <a name="Pihrtsoft_Snippets_Comparers_LiteralComparer_Compare_Pihrtsoft_Snippets_Literal_Pihrtsoft_Snippets_Literal_"></a>

### Summary

Compares two literals and returns an indication of their relative sort order\.

```csharp
public int Compare(Pihrtsoft.Snippets.Literal x, Pihrtsoft.Snippets.Literal y)
```

### Parameters

**x**

A [Literal](../../../Literal/README.md) to compare to **y**\.

**y**

A [Literal](../../../Literal/README.md) to compare to **x**\.

### Returns

System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A signed integer that indicates the relative values of **x** and **y**\.

### Implements

* System\.Collections\.Generic\.[IComparer\<Literal>.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1.compare)

## Compare\(Object, Object\) <a name="Pihrtsoft_Snippets_Comparers_LiteralComparer_Compare_System_Object_System_Object_"></a>

### Summary

Compares two objects and returns an indication of their relative sort order\.

```csharp
public int Compare(object x, object y)
```

### Parameters

**x**

An object to compare to **y**\.

**y**

An object to compare to **x**\.

### Returns

System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A signed integer that indicates the relative values of **x** and **y**\.

### Implements

* System\.Collections\.[IComparer.Compare](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icomparer.compare)
