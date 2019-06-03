# SnippetSerializer\.DeserializeFiles\(String, SearchOption\) Method

[Home](../../../../README.md)

**Containing Type**: [SnippetSerializer](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Returns enumerable collection of [SnippetFile](../../SnippetFile/README.md) deserialized from snippet files in a specified directory\.

```csharp
public static System.Collections.Generic.IEnumerable<Pihrtsoft.Snippets.SnippetFile> DeserializeFiles(string directoryPath, System.IO.SearchOption searchOption = TopDirectoryOnly)
```

### Parameters

**directoryPath** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The absolute or relative path to the directory to search\.

**searchOption** &ensp; [SearchOption](https://docs.microsoft.com/en-us/dotnet/api/system.io.searchoption)

A [SearchOption](https://docs.microsoft.com/en-us/dotnet/api/system.io.searchoption) value that specifies whether the search should include all subdirectories or only current directory\.

### Returns

[IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[SnippetFile](../../SnippetFile/README.md)>

An enumerable collection [SnippetFile](../../SnippetFile/README.md) being deserialized\.