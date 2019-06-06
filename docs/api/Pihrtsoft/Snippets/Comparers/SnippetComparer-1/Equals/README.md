# SnippetComparer\.Equals Method

[Home](../../../../../README.md)

**Containing Type**: [SnippetComparer\<T>](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Equals(Object, Object)](#Pihrtsoft_Snippets_Comparers_SnippetComparer_1_Equals_System_Object_System_Object_) | Indicates whether two objects are equal\. \(Overrides [SnippetComparer.Equals](../../SnippetComparer/Equals/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_Equals_System_Object_System_Object_)\) |
| [Equals(Snippet, Snippet)](#Pihrtsoft_Snippets_Comparers_SnippetComparer_1_Equals_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_) | Indicates whether two snippets are equal\. \(Overrides [SnippetComparer.Equals](../../SnippetComparer/Equals/README.md#Pihrtsoft_Snippets_Comparers_SnippetComparer_Equals_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_)\) |

## Equals\(Object, Object\) <a name="Pihrtsoft_Snippets_Comparers_SnippetComparer_1_Equals_System_Object_System_Object_"></a>

\
Indicates whether two objects are equal\.

```csharp
public override bool Equals(object x, object y)
```

### Parameters

**x** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

An object to compare to **y**\.

**y** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

An object to compare to **x**\.

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

`true` if **x** and **y** refer to the same object, or **x** and **y** are both the same type of object and those objects are equal; otherwise, `false`\.

## Equals\(Snippet, Snippet\) <a name="Pihrtsoft_Snippets_Comparers_SnippetComparer_1_Equals_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_Snippet_"></a>

\
Indicates whether two snippets are equal\.

```csharp
public override bool Equals(Pihrtsoft.Snippets.Snippet x, Pihrtsoft.Snippets.Snippet y)
```

### Parameters

**x** &ensp; [Snippet](../../../Snippet/README.md)

A [Snippet](../../../Snippet/README.md) to compare to **y**\.

**y** &ensp; [Snippet](../../../Snippet/README.md)

A [Snippet](../../../Snippet/README.md) to compare to **x**\.

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

`true` if **x** and **y** refer to the same object, or **x** and **y** are `null`, or **x** and **y** are equal; otherwise, `false`\.