
# Game Creator Scale Retrieval Properties

## Overview
This documentation covers classes that provide the functionality to retrieve the scale of game objects as `Vector3` values from different variable types in Game Creator 2. These classes are useful for scenarios where object scaling needs to be dynamically accessed or modified within global and local game contexts.

## Class Summaries

### Scale Retrieval Classes
- `GetScaleGlobalList`: Retrieves the scale as a `Vector3` from a Global List Variable by index.
- `GetScaleGlobalName`: Obtains the scale as a `Vector3` from a Global Name Variable.
- `GetScaleLocalList`: Fetches the scale as a `Vector3` from a Local List Variable by index.
- `GetScaleLocalName`: Retrieves the scale as a `Vector3` from a Local Name Variable.

## Usage Example
The following is a hypothetical example showcasing how to use these classes:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class ScaleManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetScaleGlobalList globalListScaleGetter;
    private GetScaleGlobalName globalNameScaleGetter;
    // Additional getters for local list and name would be defined similarly

    public Vector3 GetGlobalListScale(int index)
    {
        // Retrieves scale Vector3 from the specified index in the global list
        return globalListScaleGetter.Get(index);
    }

    public Vector3 GetGlobalNameScale(string name)
    {
        // Retrieves scale Vector3 from a global name variable
        return globalNameScaleGetter.Get(name);
    }

    // Additional methods for local list and name scale retrievals would follow a similar pattern
}
```

## Note
The `Get()` method shown in the examples is representative. Actual implementation details might differ, and these examples should be adapted according to the specific API of Game Creator 2 and your game's requirements.
