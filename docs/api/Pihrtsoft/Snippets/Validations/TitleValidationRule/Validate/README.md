# TitleValidationRule\.Validate\(Snippet\) Method

[Home](../../../../../README.md)

**Containing Type**: Pihrtsoft\.Snippets\.Validations\.[TitleValidationRule](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Validates a title of the specified [Snippet](../../../Snippet/README.md)\.

```csharp
public override System.Collections.Generic.IEnumerable<Pihrtsoft.Snippets.Validations.SnippetValidationResult> Validate(Pihrtsoft.Snippets.Snippet snippet)
```

### Parameters

**snippet** &emsp; Pihrtsoft\.Snippets\.[Snippet](../../../Snippet/README.md)

A snippet to be validated\.

### Returns

System\.Collections\.Generic\.[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<Pihrtsoft\.Snippets\.Validations\.[SnippetValidationResult](../../SnippetValidationResult/README.md)>

Enumerable collection of validation results\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippet** is `null`\.

