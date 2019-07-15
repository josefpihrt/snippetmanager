# PlaceholderCollection Class

[Home](../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Indexers](#indexers) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [Pihrtsoft.Snippets](../README.md)

**Assembly**: Pihrtsoft\.Snippets\.dll

\
Represents the set of [Placeholder](../Placeholder/README.md)s\. This collection is read\-only\.

```csharp
public class PlaceholderCollection : System.Collections.ObjectModel.ReadOnlyCollection<Pihrtsoft.Snippets.Placeholder>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1) &#x2192; PlaceholderCollection

### Implements

* [ICollection](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icollection)
* [ICollection](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)\<[Placeholder](../Placeholder/README.md)>
* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[Placeholder](../Placeholder/README.md)>
* [IList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ilist)
* [IList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)\<[Placeholder](../Placeholder/README.md)>

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [PlaceholderCollection(IList\<Placeholder>)](-ctor/README.md) | Initializes a new instance of the [PlaceholderCollection](./README.md) class that is a read\-only wrapper around the specified list\. |

## Indexers

| Indexer | Summary |
| ------- | ------- |
| [Item\[Int32\]](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.item) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |
| [Item\[String\]](Item/README.md) | Returns first placeholder with the specified identifier |

## Properties

| Property | Summary |
| -------- | ------- |
| [Count](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.count) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |
| [Items](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.items) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [Contains(Placeholder)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.contains) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |
| [Contains(String)](Contains/README.md) | Determines whether the [PlaceholderCollection](./README.md) contains an item with a specified **identifier**\. |
| [ContainsEnd()](ContainsEnd/README.md) | Determines whether the [PlaceholderCollection](./README.md) contains an item with identifier equal to [Placeholder.EndIdentifier](../Placeholder/EndIdentifier/README.md)\. |
| [ContainsSelected()](ContainsSelected/README.md) | Determines whether the [PlaceholderCollection](./README.md) contains an item with identifier equal to [Placeholder.SelectedIdentifier](../Placeholder/SelectedIdentifier/README.md)\. |
| [CopyTo(Placeholder\[\], Int32)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.copyto) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Find(String)](Find/README.md) | Returns first placeholder with the specified identifier |
| [FindAll(String)](FindAll/README.md) | Returns all placeholders with the specified identifier |
| [GetEnumerator()](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.getenumerator) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [IndexOf(Placeholder)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1.indexof) |  \(Inherited from [ReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.readonlycollection-1)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

