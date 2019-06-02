# LiteralRenamer\.Rename\(Snippet, String, String\) Method

[Home](../../../../README.md)

**Containing Type**: Pihrtsoft\.Snippets\.[LiteralRenamer](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Renames snippet literal including its occurrences in the code\.

```csharp
public static void Rename(Pihrtsoft.Snippets.Snippet snippet, string oldIdentifier, string newIdentifier)
```

### Parameters

**snippet** &emsp; Pihrtsoft\.Snippets\.[Snippet](../../Snippet/README.md)

[Snippet](../../Snippet/README.md) that contains the literal to rename\.

**oldIdentifier** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Old identifier\.

**newIdentifier** &emsp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

New identifier\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippet** is `null`\.

