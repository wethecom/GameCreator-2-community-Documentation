
# Game Creator Position Retrieval Properties

## Overview
This documentation outlines classes designed to retrieve positional data of game objects as `Vector3` values from various types of variables within Game Creator 2. These classes are crucial for games that involve dynamic positioning of objects in global and local contexts.

## Class Summaries

### Position Retrieval Classes
- `GetPositionGlobalList`: Retrieves the position as a `Vector3` from a Global List Variable by index.
- `GetPositionGlobalName`: Obtains the position as a `Vector3` from a Global Name Variable.
- `GetPositionLocalList`: Fetches the position as a `Vector3` from a Local List Variable by index.
- `GetPositionLocalName`: Retrieves the position as a `Vector3` from a Local Name Variable.

## Usage Example
The following is a hypothetical example showcasing how to use these classes:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class PositionManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetPositionGlobalList globalListPositionGetter;
    private GetPositionGlobalName globalNamePositionGetter;
    // Other getters for local list and name would be defined similarly

    public Vector3 GetGlobalListPosition(int index)
    {
        // Retrieves position Vector3 from the specified index in the global list
        return globalListPositionGetter.Get(index);
    }

    public Vector3 GetGlobalNamePosition(string name)
    {
        // Retrieves position Vector3 from a global name variable
        return globalNamePositionGetter.Get(name);
    }

    // Additional methods for local list and name position retrievals would follow a similar pattern
}
```

## Note
The `Get()` method shown in the examples is representative. Actual implementation details might differ, and these examples should be adapted according to the specific API of Game Creator 2 and your game's requirements.
