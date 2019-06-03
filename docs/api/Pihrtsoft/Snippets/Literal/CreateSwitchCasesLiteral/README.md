# Literal\.CreateSwitchCasesLiteral\(String, String, String, String\) Method

[Home](../../../../README.md)

**Containing Type**: [Literal](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

## Summary

Create new [Literal](../README.md) with function generates switch cases\.

```csharp
public static Pihrtsoft.Snippets.Literal CreateSwitchCasesLiteral(string identifier, string expressionIdentifier, string toolTip = null, string defaultValue = "default:")
```

### Parameters

**identifier** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The [Literal](../README.md) identifier\.

**expressionIdentifier** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

Identifier of the literal that represent switch expression\.

**toolTip** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The [Literal](../README.md) description\.

**defaultValue** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

The [Literal](../README.md)default value\.

### Returns

[Literal](../README.md)

[Literal](../README.md) with function that generates switch cases\.

### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)

**identifier** is `null`\.

