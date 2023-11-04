
# Game Creator String Retrieval Properties

## Overview
This documentation details classes for retrieving `string` values from different types of variables in Game Creator 2. These properties are essential for games that require manipulation of text data, such as dialogue management, item descriptions, or dynamic notifications.

## Class Summaries

### String Retrieval Classes
- `GetStringGlobalList`: Retrieves a `string` from a Global List Variable by index.
- `GetStringGlobalName`: Obtains a `string` from a Global Name Variable.
- `GetStringLocalList`: Fetches a `string` from a Local List Variable by index.
- `GetStringLocalName`: Retrieves a `string` from a Local Name Variable.

## Usage Example
Below is an example of how you could use these classes in a game scenario:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class TextManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetStringGlobalList globalListStringGetter;
    private GetStringGlobalName globalNameStringGetter;
    private GetStringLocalList localListStringGetter;
    private GetStringLocalName localNameStringGetter;

    public string GetGlobalListString(int index)
    {
        // Retrieves string from the specified index in the global list
        return globalListStringGetter.Get(index);
    }

    public string GetGlobalNameString(string name)
    {
        // Retrieves string from a global name variable
        return globalNameStringGetter.Get(name);
    }

    public string GetLocalListString(int index)
    {
        // Retrieves string from the specified index in the local list
        return localListStringGetter.Get(index);
    }

    public string GetLocalNameString(string name)
    {
        // Retrieves string from a local name variable
        return localNameStringGetter.Get(name);
    }
}
```

## Note
The `Get()` method mentioned in the examples is for illustrative purposes. Real implementation may differ, and these examples should be tailored to the specific API of Game Creator 2 and the unique requirements of your project.
