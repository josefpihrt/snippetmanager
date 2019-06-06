# SnippetTypeValidationRule\.Validate\(Snippet\) Method

[Home](../../../../../README.md)

**Containing Type**: [SnippetTypeValidationRule](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

\
Validates a format version of the specified [Snippet](../../../Snippet/README.md)\.

```csharp
public override System.Collections.Generic.IEnumerable<Pihrtsoft.Snippets.Validations.SnippetValidationResult> Validate(Pihrtsoft.Snippets.Snippet snippet)
```

### Parameters

**snippet** &ensp; [Snippet](../../../Snippet/README.md)

A snippet to be validated\.

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[SnippetValidationResult](../../SnippetValidationResult/README.md)>

Enumerable collection of validation results\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippet** is `null`\.

