# SnippetComparer\.GetHashCode Method

[Home](../../../../../README.md)

**Containing Type**: Pihrtsoft\.Snippets\.Comparers\.[SnippetComparer](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [GetHashCode(Object)](#Pihrtsoft_Snippets_Comparers_SnippetComparer_GetHashCode_System_Object_) | Gets the hash code for the specified object\. \(Implements [IEqualityComparer.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer.gethashcode)\) |
| [GetHashCode(Snippet)](#Pihrtsoft_Snippets_Comparers_SnippetComparer_GetHashCode_Pihrtsoft_Snippets_Snippet_) | Gets the hash code for the specified [Snippet](../../../Snippet/README.md)\. \(Implements [IEqualityComparer\<Snippet>.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1.gethashcode)\) |

## GetHashCode\(Object\) <a name="Pihrtsoft_Snippets_Comparers_SnippetComparer_GetHashCode_System_Object_"></a>

### Summary

Gets the hash code for the specified object\.

```csharp
public abstract int GetHashCode(object obj)
```

### Parameters

**obj**

An object\.

### Returns

System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A 32\-bit signed hash code calculated from the value of the **obj**\.

### Implements

* System\.Collections\.[IEqualityComparer.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.collections.iequalitycomparer.gethashcode)

## GetHashCode\(Snippet\) <a name="Pihrtsoft_Snippets_Comparers_SnippetComparer_GetHashCode_Pihrtsoft_Snippets_Snippet_"></a>

### Summary

Gets the hash code for the specified [Snippet](../../../Snippet/README.md)\.

```csharp
public abstract int GetHashCode(Pihrtsoft.Snippets.Snippet obj)
```

### Parameters

**obj**

A snippet\.

### Returns

System\.[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A 32\-bit signed hash code calculated from the value of the **obj**\.

### Implements

* System\.Collections\.Generic\.[IEqualityComparer\<Snippet>.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1.gethashcode)
