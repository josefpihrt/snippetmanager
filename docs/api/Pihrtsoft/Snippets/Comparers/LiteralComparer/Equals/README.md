# LiteralComparer\.Equals Method

[Home](../../../../../README.md)

**Containing Type**: Pihrtsoft\.Snippets\.Comparers\.[LiteralComparer](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Equals(Literal, Literal)](#Pihrtsoft_Snippets_Comparers_LiteralComparer_Equals_Pihrtsoft_Snippets_Literal_Pihrtsoft_Snippets_Literal_) | Indicates whether two literals are equal\. \(Implements [IEqualityComparer\<Literal>.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1.equals)\) |
| [Equals(Object, Object)](#Pihrtsoft_Snippets_Comparers_LiteralComparer_Equals_System_Object_System_Object_) | Indicates whether two objects are equal\. \(Implements [IEqualityComparer.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer.equals)\) |

## Equals\(Literal, Literal\) <a name="Pihrtsoft_Snippets_Comparers_LiteralComparer_Equals_Pihrtsoft_Snippets_Literal_Pihrtsoft_Snippets_Literal_"></a>

### Summary

Indicates whether two literals are equal\.

```csharp
public bool Equals(Pihrtsoft.Snippets.Literal x, Pihrtsoft.Snippets.Literal y)
```

### Parameters

**x**

A [Literal](../../../Literal/README.md) to compare to **y**\.

**y**

A [Literal](../../../Literal/README.md) to compare to **x**\.

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

`true` if **x** and **y** refer to the same object, or **x** and **y** are `null`, or **x** and **y** are equal; otherwise, `false`\.

### Implements

* System\.Collections\.Generic\.[IEqualityComparer\<Literal>.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1.equals)

## Equals\(Object, Object\) <a name="Pihrtsoft_Snippets_Comparers_LiteralComparer_Equals_System_Object_System_Object_"></a>

### Summary

Indicates whether two objects are equal\.

```csharp
public bool Equals(object x, object y)
```

### Parameters

**x**

An object to compare to **y**\.

**y**

An object to compare to **x**\.

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

`true` if **x** and **y** refer to the same object, or **x** and **y** are both the same type of object and those objects are equal; otherwise, `false`\.

### Implements

* System\.Collections\.[IEqualityComparer.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer.equals)
