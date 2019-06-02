# Snippet Class

[Home](../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Fields](#fields) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods) &#x2022; [Events](#events)

**Namespace**: [Pihrtsoft.Snippets](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Represents a code snippet\.

```csharp
public class Snippet : ICloneable
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; Snippet

### Implements

* [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [Snippet()](-ctor/README.md) | Initializes a new instance of the [Snippet](./README.md) class\. |

## Fields

| Field | Summary |
| ----- | ------- |
| [DefaultDelimiter](DefaultDelimiter/README.md) | Represents a default delimiter in a snippet code\. This field is a constant\. \(Value = '$'\) |
| [DefaultFormatVersion](DefaultFormatVersion/README.md) | Represents code snippet default format version\. This field is read\-only\. |

## Properties

| Property | Summary |
| -------- | ------- |
| [AlternativeShortcuts](AlternativeShortcuts/README.md) | Gets a collection of alternative shortcuts\. |
| [AssemblyReferences](AssemblyReferences/README.md) | Gets a collection of snippet assembly references\. |
| [Author](Author/README.md) | Gets or sets snippet author\. |
| [Code](Code/README.md) | Gets the snippet code\. |
| [CodeText](CodeText/README.md) | Gets or sets snippet code text\. |
| [ContextKind](ContextKind/README.md) | Gets or sets snippet code context\. |
| [Delimiter](Delimiter/README.md) | Gets or sets a delimiter that encloses placeholder in the code\. |
| [Description](Description/README.md) | Gets or sets snippet description\. |
| [FilePath](FilePath/README.md) | Gets or sets full path to the snippet file\. |
| [FormatVersion](FormatVersion/README.md) | Gets or sets snippet format version\. |
| [HasAlternativeShortcuts](HasAlternativeShortcuts/README.md) | Gets a value indicating whether snippet contains alternative shortcut\. |
| [HasDefaultDelimiter](HasDefaultDelimiter/README.md) | Gets a value indicating whether the current instance has default delimiter\. |
| [HelpUrl](HelpUrl/README.md) | Gets or sets URL the provides additional information about the current instance\. |
| [Index](Index/README.md) | Gets or sets index of a snippet in a snippet file\. |
| [IsExpansion](IsExpansion/README.md) | Gets or sets a value indicating whether the current instance has [SnippetTypes.Expansion](../SnippetTypes/Expansion/README.md) flag set\. |
| [IsRefactoring](IsRefactoring/README.md) | Gets or sets a value indicating whether the current instance has [SnippetTypes.Refactoring](../SnippetTypes/Refactoring/README.md) flag set\. |
| [IsSurroundsWith](IsSurroundsWith/README.md) | Gets or sets a value indicating whether the current instance has [SnippetTypes.SurroundsWith](../SnippetTypes/SurroundsWith/README.md) flag set\. |
| [Keywords](Keywords/README.md) | Gets a collection of snippet keywords\. |
| [Language](Language/README.md) | Gets or sets code snippet programming language\. |
| [Literals](Literals/README.md) | Gets a collection of snippet literals\. |
| [Namespaces](Namespaces/README.md) | Gets a collection of snippet namespaces\. |
| [Placeholders](Placeholders/README.md) | Gets a collection of literal placeholders\. |
| [Shortcut](Shortcut/README.md) | Gets or sets snippet shortcut\. |
| [SnippetTypes](SnippetTypes/README.md) | Gets or sets snippet type\. |
| [Title](Title/README.md) | Gets or sets snippet title\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Clone()](Clone/README.md) | Creates a new [Snippet](./README.md) that is a deep copy of the current instance\. \(Implements [ICloneable.Clone](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable.clone)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [OnTextChanged(EventArgs)](OnTextChanged/README.md) | Raises the [Snippet.TextChanged](TextChanged/README.md) event\. |
| [Save(Stream)](Save/README.md#Pihrtsoft_Snippets_Snippet_Save_System_IO_Stream_) | Serializes the current instance to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)\. |
| [Save(Stream, SaveSettings)](Save/README.md#Pihrtsoft_Snippets_Snippet_Save_System_IO_Stream_Pihrtsoft_Snippets_SaveSettings_) | Serializes the current instance to the specified [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream), optionally specifying serialization process\. |
| [Save(String)](Save/README.md#Pihrtsoft_Snippets_Snippet_Save_System_String_) | Serializes the current instance to the specified file\. |
| [Save(String, SaveSettings)](Save/README.md#Pihrtsoft_Snippets_Snippet_Save_System_String_Pihrtsoft_Snippets_SaveSettings_) | Serializes the current instance to the specified file\. |
| [Shortcuts()](Shortcuts/README.md) | Returns snippet shortcut and all alternative shortcuts, if any\. |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

## Events

| Event | Summary |
| ----- | ------- |
| [TextChanged](TextChanged/README.md) | Occurs when the snippet text changes\. |

