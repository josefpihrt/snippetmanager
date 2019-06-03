# Snippet\.Save Method

[Home](../../../../README.md)

**Containing Type**: [Snippet](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Save(Stream)](#Pihrtsoft_Snippets_Snippet_Save_System_IO_Stream_) | Serializes the current instance to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\. |
| [Save(Stream, SaveSettings)](#Pihrtsoft_Snippets_Snippet_Save_System_IO_Stream_Pihrtsoft_Snippets_SaveSettings_) | Serializes the current instance to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally specifying serialization process\. |
| [Save(String)](#Pihrtsoft_Snippets_Snippet_Save_System_String_) | Serializes the current instance to the specified file\. |
| [Save(String, SaveSettings)](#Pihrtsoft_Snippets_Snippet_Save_System_String_Pihrtsoft_Snippets_SaveSettings_) | Serializes the current instance to the specified file\. |

## Save\(Stream\) <a name="Pihrtsoft_Snippets_Snippet_Save_System_IO_Stream_"></a>

### Summary

Serializes the current instance to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\.

```csharp
public void Save(System.IO.Stream stream)
```

### Parameters

**stream** &ensp; [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)

The stream to output this [Snippet](../README.md) to\.

## Save\(Stream, SaveSettings\) <a name="Pihrtsoft_Snippets_Snippet_Save_System_IO_Stream_Pihrtsoft_Snippets_SaveSettings_"></a>

### Summary

Serializes the current instance to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally specifying serialization process\.

```csharp
public void Save(System.IO.Stream stream, Pihrtsoft.Snippets.SaveSettings settings)
```

### Parameters

**stream** &ensp; [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)

The stream to output this [Snippet](../README.md) to\.

**settings** &ensp; [SaveSettings](../../SaveSettings/README.md)

A [SaveSettings](../../SaveSettings/README.md) that modify serialization process\.

## Save\(String\) <a name="Pihrtsoft_Snippets_Snippet_Save_System_String_"></a>

### Summary

Serializes the current instance to the specified file\.

```csharp
public void Save(string filePath)
```

### Parameters

**filePath** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The absolute or relative path to the file\.

## Save\(String, SaveSettings\) <a name="Pihrtsoft_Snippets_Snippet_Save_System_String_Pihrtsoft_Snippets_SaveSettings_"></a>

### Summary

Serializes the current instance to the specified file\.

```csharp
public void Save(string filePath, Pihrtsoft.Snippets.SaveSettings settings)
```

### Parameters

**filePath** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The absolute or relative path to the file\.

**settings** &ensp; [SaveSettings](../../SaveSettings/README.md)

A [SaveSettings](../../SaveSettings/README.md) that modify serialization process\.