# SnippetComparer\.GetHashCode Method

[Home](../../../../../README.md)

**Containing Type**: [SnippetComparer\<T>](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [GetHashCode(Object)](#Pihrtsoft_Snippets_Comparers_SnippetComparer_1_GetHashCode_System_Object_) | Gets the hash code for the specified object\. \(Overrides [SnippetComparer.GetHashCode](../../SnippetComparer/GetHashCode/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_GetHashCode_System_Object_)\) |
| [GetHashCode(Snippet)](#Pihrtsoft_Snippets_Comparers_SnippetComparer_1_GetHashCode_Pihrtsoft_Snippets_Snippet_) | Gets the hash code for the specified [Snippet](../../../Snippet/README.md)\. \(Overrides [SnippetComparer.GetHashCode](../../SnippetComparer/GetHashCode/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_GetHashCode_Pihrtsoft_Snippets_Snippet_)\) |

## GetHashCode\(Object\) <a name="Pihrtsoft_Snippets_Comparers_SnippetComparer_1_GetHashCode_System_Object_"></a>

### Summary

Gets the hash code for the specified object\.

```csharp
public override int GetHashCode(object obj)
```

### Parameters

**obj** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

An object\.

### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A 32\-bit signed hash code calculated from the value of the **obj**\.

## GetHashCode\(Snippet\) <a name="Pihrtsoft_Snippets_Comparers_SnippetComparer_1_GetHashCode_Pihrtsoft_Snippets_Snippet_"></a>

### Summary

Gets the hash code for the specified [Snippet](../../../Snippet/README.md)\.

```csharp
public override int GetHashCode(Pihrtsoft.Snippets.Snippet obj)
```

### Parameters

**obj** &ensp; [Snippet](../../../Snippet/README.md)

A snippet\.

### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

A 32\-bit signed hash code calculated from the value of the **obj**\.