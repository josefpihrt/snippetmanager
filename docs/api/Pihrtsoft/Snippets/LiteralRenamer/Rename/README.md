# LiteralRenamer\.Rename\(Snippet, String, String\) Method

[Home](../../../../README.md)

**Containing Type**: [LiteralRenamer](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Renames snippet literal including its occurrences in the code\.

```csharp
public static void Rename(Pihrtsoft.Snippets.Snippet snippet, string oldIdentifier, string newIdentifier)
```

### Parameters

**snippet** &ensp; [Snippet](../../Snippet/README.md)

[Snippet](../../Snippet/README.md) that contains the literal to rename\.

**oldIdentifier** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Old identifier\.

**newIdentifier** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

New identifier\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippet** is `null`\.

