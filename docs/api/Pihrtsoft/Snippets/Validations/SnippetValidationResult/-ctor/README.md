# SnippetValidationResult Constructors

[Home](../../../../../README.md)

**Containing Type**: Pihrtsoft\.Snippets\.Validations\.[SnippetValidationResult](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Constructor | Summary |
| ----------- | ------- |
| [SnippetValidationResult(Snippet, String, String, ResultImportance)](#Pihrtsoft_Snippets_Validations_SnippetValidationResult__ctor_Pihrtsoft_Snippets_Snippet_System_String_System_String_Pihrtsoft_Snippets_Validations_ResultImportance_) | Initializes a new instance of the [SnippetValidationResult](../README.md) class using the specified snippet, code, description a and importance\. |
| [SnippetValidationResult(Snippet, String, String, ResultImportance, Object)](#Pihrtsoft_Snippets_Validations_SnippetValidationResult__ctor_Pihrtsoft_Snippets_Snippet_System_String_System_String_Pihrtsoft_Snippets_Validations_ResultImportance_System_Object_) | Initializes a new instance of the [SnippetValidationResult](../README.md) class using the specified snippet, code, description, importance and content\. |

## SnippetValidationResult\(Snippet, String, String, ResultImportance\) <a name="Pihrtsoft_Snippets_Validations_SnippetValidationResult__ctor_Pihrtsoft_Snippets_Snippet_System_String_System_String_Pihrtsoft_Snippets_Validations_ResultImportance_"></a>

### Summary

Initializes a new instance of the [SnippetValidationResult](../README.md) class using the specified snippet, code, description a and importance\.

```csharp
public SnippetValidationResult(Pihrtsoft.Snippets.Snippet snippet, string code, string description, Pihrtsoft.Snippets.Validations.ResultImportance importance)
```

### Parameters

**snippet** &emsp; Pihrtsoft\.Snippets\.[Snippet](../../../Snippet/README.md)

A snippet\.

**code** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Alphanumeric code the identifies the result\.

**description** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Result description\.

**importance** &emsp; Pihrtsoft\.Snippets\.Validations\.[ResultImportance](../../ResultImportance/README.md)

Result importance\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippet** is `null`\.

## SnippetValidationResult\(Snippet, String, String, ResultImportance, Object\) <a name="Pihrtsoft_Snippets_Validations_SnippetValidationResult__ctor_Pihrtsoft_Snippets_Snippet_System_String_System_String_Pihrtsoft_Snippets_Validations_ResultImportance_System_Object_"></a>

### Summary

Initializes a new instance of the [SnippetValidationResult](../README.md) class using the specified snippet, code, description, importance and content\.

```csharp
public SnippetValidationResult(Pihrtsoft.Snippets.Snippet snippet, string code, string description, Pihrtsoft.Snippets.Validations.ResultImportance importance, object content)
```

### Parameters

**snippet** &emsp; Pihrtsoft\.Snippets\.[Snippet](../../../Snippet/README.md)

A snippet\.

**code** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Alphanumeric code the identifies the result\.

**description** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Result description\.

**importance** &emsp; Pihrtsoft\.Snippets\.Validations\.[ResultImportance](../../ResultImportance/README.md)

Result importance\.

**content** &emsp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

Additional result content\. The value can be `null`\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippet** is `null`\.

