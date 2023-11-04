
# Game Creator Offset Retrieval Properties

## Overview
This documentation section highlights classes tasked with retrieving `Vector3` offset values from various variable types in Game Creator 2. These properties are essential for games that require dynamic offset adjustments for objects in both global and local contexts.

## Class Summaries

### Offset Retrieval Classes
- `GetOffsetGlobalList`: Retrieves an offset as a `Vector3` from a Global List Variable by index.
- `GetOffsetGlobalName`: Obtains an offset as a `Vector3` from a Global Name Variable.
- `GetOffsetLocalList`: Fetches an offset as a `Vector3` from a Local List Variable by index.
- `GetOffsetLocalName`: Retrieves an offset as a `Vector3` from a Local Name Variable.

## Usage Example
Below is a hypothetical usage example for these classes:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class OffsetManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetOffsetGlobalList globalListOffsetGetter;
    private GetOffsetGlobalName globalNameOffsetGetter;
    // Other getters for local list and name would be defined similarly

    public Vector3 GetGlobalListOffset(int index)
    {
        // Retrieves offset Vector3 from the specified index in the global list
        return globalListOffsetGetter.Get(index);
    }

    public Vector3 GetGlobalNameOffset(string name)
    {
        // Retrieves offset Vector3 from a global name variable
        return globalNameOffsetGetter.Get(name);
    }

    // Additional methods for local list and name offset retrievals would follow a similar pattern
}
```

## Note
The `Get()` method shown in the examples is representative. Actual implementation details might differ, and these examples should be adapted according to the specific API of Game Creator 2 and your game's requirements.
