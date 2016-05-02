# Snippet Manager

## Introduction 
* Snippet Manager is .NET library that enables to work with Visual Studio snippets. 
* The library is distributed via [NuGet](https://www.nuget.org/packages/SnippetManager).

## Usage 

#### Namespaces
```c#
using Pihrtsoft.Snippets;
using Pihrtsoft.Snippets.Comparers;
using Pihrtsfot.Snippets.Validations;
```

#### Load Snippets from Directory
```c#
public static IEnumerable<Snippet> LoadSnippets(string directoryPath)
{
    return SnippetSerializer.DeserializeFiles(directoryPath, SearchOption.AllDirectories)
        .SelectMany(f => f.Snippets));
}
```

#### Validate Snippets
```c#
public static IEnumerable<SnippetValidationResult> ValidateSnippets(IEnumerable<Snippet> snippets)
{
    SnippetValidator validator = SnippetValidator.CreateDefaultValidator();
    foreach (Snippet snippet in snippets)
    {
        foreach (SnippetValidationResult result in validator.Validate(snippet))
            yield return result;
    }
}
```

#### Find Duplicate Shortcuts
```c#
public static IEnumerable<IGrouping<string, Snippet>> FindDuplicateShortcuts(IEnumerable<Snippet> snippets)
{
    foreach (IGrouping<string, Snippet> grouping in SnippetUtility.FindDuplicateShortcuts(snippets))
        yield return grouping;
}
```

#### Get Changed Snippets
```c#
public static IEnumerable<Snippet> GetChangedSnippets(IEnumerable<Snippet> snippets)
{
    var equalityComparer = new SnippetDeepEqualityComparer();

    foreach (Snippet snippet in snippets)
    {
        var clone = (Snippet)snippet.Clone();

        clone.Literals.Sort();
        clone.Keywords.Sort();
        clone.Namespaces.Sort();
        
        // do some other processing

        if (!equalityComparer.Equals(snippet, clone))
            yield return clone;
    }
}
```
