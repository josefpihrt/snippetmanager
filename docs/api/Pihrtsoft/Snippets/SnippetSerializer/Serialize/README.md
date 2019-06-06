# SnippetSerializer\.Serialize Method

[Home](../../../../README.md)

**Containing Type**: [SnippetSerializer](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Serialize(SnippetFile)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_Pihrtsoft_Snippets_SnippetFile_) | Serializes the specified [SnippetFile](../../SnippetFile/README.md) to the file\. |
| [Serialize(SnippetFile, SaveSettings)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_Pihrtsoft_Snippets_SnippetFile_Pihrtsoft_Snippets_SaveSettings_) | Serializes the specified [SnippetFile](../../SnippetFile/README.md) to the file, optionally using [SaveSettings](../../SaveSettings/README.md) to modify serialization process\. |
| [Serialize(Stream, IEnumerable\<Snippet>)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__) | Serializes enumerable collection of [Snippet](../../Snippet/README.md) to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\. |
| [Serialize(Stream, IEnumerable\<Snippet>, SaveSettings)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__Pihrtsoft_Snippets_SaveSettings_) | Serializes enumerable collection of [Snippet](../../Snippet/README.md) to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally using [SaveSettings](../../SaveSettings/README.md) to modify serialization process\. |
| [Serialize(Stream, Snippet)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_Pihrtsoft_Snippets_Snippet_) | Serializes the specified [Snippet](../../Snippet/README.md) the the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\. |
| [Serialize(Stream, Snippet, SaveSettings)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_SaveSettings_) | Serializes the specified [Snippet](../../Snippet/README.md) the the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally using [SaveSettings](../../SaveSettings/README.md) to modify serialization process\. |
| [Serialize(String, IEnumerable\<Snippet>)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__) | Serializes enumerable collection of [Snippet](../../Snippet/README.md) to the specified snippet file\. |
| [Serialize(String, IEnumerable\<Snippet>, SaveSettings)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__Pihrtsoft_Snippets_SaveSettings_) | Serializes enumerable collection of [Snippet](../../Snippet/README.md) to the specified snippet file, optionally using [SaveSettings](../../SaveSettings/README.md) to modify serialization process\. |
| [Serialize(String, Snippet)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_Pihrtsoft_Snippets_Snippet_) | Serializes the specified [Snippet](../../Snippet/README.md) the the specified snippet file\. |
| [Serialize(String, Snippet, SaveSettings)](#Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_SaveSettings_) | Serializes the specified [Snippet](../../Snippet/README.md) the the specified snippet file, optionally using [SaveSettings](../../SaveSettings/README.md) to modify serialization process\. |

## Serialize\(SnippetFile\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_Pihrtsoft_Snippets_SnippetFile_"></a>

\
Serializes the specified [SnippetFile](../../SnippetFile/README.md) to the file\.

```csharp
public static void Serialize(Pihrtsoft.Snippets.SnippetFile snippetFile)
```

### Parameters

**snippetFile** &ensp; [SnippetFile](../../SnippetFile/README.md)

A snippet file to be serialized\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippetFile** is `null`\.

## Serialize\(SnippetFile, SaveSettings\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_Pihrtsoft_Snippets_SnippetFile_Pihrtsoft_Snippets_SaveSettings_"></a>

\
Serializes the specified [SnippetFile](../../SnippetFile/README.md) to the file, optionally using [SaveSettings](../../SaveSettings/README.md) to modify serialization process\.

```csharp
public static void Serialize(Pihrtsoft.Snippets.SnippetFile snippetFile, Pihrtsoft.Snippets.SaveSettings settings)
```

### Parameters

**snippetFile** &ensp; [SnippetFile](../../SnippetFile/README.md)

A snippet file to be serialized\.

**settings** &ensp; [SaveSettings](../../SaveSettings/README.md)

A [SaveSettings](../../SaveSettings/README.md) that modify serialization process\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**snippetFile** is `null`\.

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**settings** is `null`\.

## Serialize\(Stream, IEnumerable\<Snippet>\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__"></a>

\
Serializes enumerable collection of [Snippet](../../Snippet/README.md) to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\.

```csharp
public static void Serialize(System.IO.Stream stream, System.Collections.Generic.IEnumerable<Pihrtsoft.Snippets.Snippet> snippets)
```

### Parameters

**stream** &ensp; [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)

The stream to output this [Snippet](../../Snippet/README.md) to\.

**snippets** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Snippet](../../Snippet/README.md)>

Enumerable collection of [Snippet](../../Snippet/README.md) to be serialized\.

## Serialize\(Stream, IEnumerable\<Snippet>, SaveSettings\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__Pihrtsoft_Snippets_SaveSettings_"></a>

\
Serializes enumerable collection of [Snippet](../../Snippet/README.md) to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally using [SaveSettings](../../SaveSettings/README.md) to modify serialization process\.

```csharp
public static void Serialize(System.IO.Stream stream, System.Collections.Generic.IEnumerable<Pihrtsoft.Snippets.Snippet> snippets, Pihrtsoft.Snippets.SaveSettings settings)
```

### Parameters

**stream** &ensp; [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)

The stream to output this [Snippet](../../Snippet/README.md) to\.

**snippets** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Snippet](../../Snippet/README.md)>

Enumerable collection of [Snippet](../../Snippet/README.md) to be serialized\.

**settings** &ensp; [SaveSettings](../../SaveSettings/README.md)

A [SaveSettings](../../SaveSettings/README.md) that modify serialization process\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**stream** or **snippets** or **settings** is `null`\.

## Serialize\(Stream, Snippet\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_Pihrtsoft_Snippets_Snippet_"></a>

\
Serializes the specified [Snippet](../../Snippet/README.md) the the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\.

```csharp
public static void Serialize(System.IO.Stream stream, Pihrtsoft.Snippets.Snippet snippet)
```

### Parameters

**stream** &ensp; [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)

The stream to output this [Snippet](../../Snippet/README.md) to\.

**snippet** &ensp; [Snippet](../../Snippet/README.md)

A [Snippet](../../Snippet/README.md) to be serialized\.

## Serialize\(Stream, Snippet, SaveSettings\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_IO_Stream_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_SaveSettings_"></a>

\
Serializes the specified [Snippet](../../Snippet/README.md) the the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally using [SaveSettings](../../SaveSettings/README.md) to modify serialization process\.

```csharp
public static void Serialize(System.IO.Stream stream, Pihrtsoft.Snippets.Snippet snippet, Pihrtsoft.Snippets.SaveSettings settings)
```

### Parameters

**stream** &ensp; [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)

The stream to output this [Snippet](../../Snippet/README.md) to\.

**snippet** &ensp; [Snippet](../../Snippet/README.md)

A [Snippet](../../Snippet/README.md) to be serialized\.

**settings** &ensp; [SaveSettings](../../SaveSettings/README.md)

A [SaveSettings](../../SaveSettings/README.md) that modify serialization process\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**stream** or **snippet** or **settings** is `null`\.

## Serialize\(String, IEnumerable\<Snippet>\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__"></a>

\
Serializes enumerable collection of [Snippet](../../Snippet/README.md) to the specified snippet file\.

```csharp
public static void Serialize(string filePath, System.Collections.Generic.IEnumerable<Pihrtsoft.Snippets.Snippet> snippets)
```

### Parameters

**filePath** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The absolute or relative path to the file\.

**snippets** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Snippet](../../Snippet/README.md)>

Enumerable collection of [Snippet](../../Snippet/README.md) to be serialized\.

## Serialize\(String, IEnumerable\<Snippet>, SaveSettings\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_System_Collections_Generic_IEnumerable_Pihrtsoft_Snippets_Snippet__Pihrtsoft_Snippets_SaveSettings_"></a>

\
Serializes enumerable collection of [Snippet](../../Snippet/README.md) to the specified snippet file, optionally using [SaveSettings](../../SaveSettings/README.md) to modify serialization process\.

```csharp
public static void Serialize(string filePath, System.Collections.Generic.IEnumerable<Pihrtsoft.Snippets.Snippet> snippets, Pihrtsoft.Snippets.SaveSettings settings)
```

### Parameters

**filePath** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The absolute or relative path to the file\.

**snippets** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Snippet](../../Snippet/README.md)>

Enumerable collection of [Snippet](../../Snippet/README.md) to be serialized\.

**settings** &ensp; [SaveSettings](../../SaveSettings/README.md)

A [SaveSettings](../../SaveSettings/README.md) that modify serialization process\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**filePath** or **snippets** or **settings** is `null`\.

## Serialize\(String, Snippet\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_Pihrtsoft_Snippets_Snippet_"></a>

\
Serializes the specified [Snippet](../../Snippet/README.md) the the specified snippet file\.

```csharp
public static void Serialize(string filePath, Pihrtsoft.Snippets.Snippet snippet)
```

### Parameters

**filePath** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The absolute or relative path to the file\.

**snippet** &ensp; [Snippet](../../Snippet/README.md)

A [Snippet](../../Snippet/README.md) to be serialized\.

## Serialize\(String, Snippet, SaveSettings\) <a name="Pihrtsoft_Snippets_SnippetSerializer_Serialize_System_String_Pihrtsoft_Snippets_Snippet_Pihrtsoft_Snippets_SaveSettings_"></a>

\
Serializes the specified [Snippet](../../Snippet/README.md) the the specified snippet file, optionally using [SaveSettings](../../SaveSettings/README.md) to modify serialization process\.

```csharp
public static void Serialize(string filePath, Pihrtsoft.Snippets.Snippet snippet, Pihrtsoft.Snippets.SaveSettings settings)
```

### Parameters

**filePath** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The absolute or relative path to the file\.

**snippet** &ensp; [Snippet](../../Snippet/README.md)

A [Snippet](../../Snippet/README.md) to be serialized\.

**settings** &ensp; [SaveSettings](../../SaveSettings/README.md)

A [SaveSettings](../../SaveSettings/README.md) that modify serialization process\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**filePath** or **snippet** or **settings** is `null`\.

