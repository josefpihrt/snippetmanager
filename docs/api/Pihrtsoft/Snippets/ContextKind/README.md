# ContextKind Enum

[Home](../../../README.md) &#x2022; [Fields](#fields)

**Namespace**: [Pihrtsoft.Snippets](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Specifies the location at which a code snippet can be inserted\.

```csharp
public enum ContextKind
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) &#x2192; ContextKind

## Fields

| Name | Value | Summary |
| ---- | ----- | ------- |
| None | 0 | Specifies that the code snippet has no context defined\. |
| Any | 1 | Specifies that the code snippet can be inserted anywhere\. |
| File | 2 | Specifies that the code snippet is a full code file\. |
| MethodBody | 3 | Specifies that the code snippet is a method body\. |
| MethodDeclaration | 4 | Specifies that the code snippet is a method\. |
| TypeDeclaration | 5 | Specifies that the code snippet can be inserted anywhere\. |

