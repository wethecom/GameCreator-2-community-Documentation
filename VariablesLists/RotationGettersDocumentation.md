
# Game Creator Rotation Retrieval Properties

## Overview
This section provides documentation for classes designed to retrieve rotation data of game objects from various types of variables in Game Creator 2. These classes enable dynamic access to object rotations, facilitating complex in-game interactions and behaviors.

## Class Summaries

### Rotation Direction Retrieval Classes
- `GetRotationDirectionGlobalList`: Retrieves a direction vector from a Global List Variable by index.
- `GetRotationDirectionGlobalName`: Obtains a direction vector from a Global Name Variable.
- `GetRotationDirectionLocalList`: Fetches a direction vector from a Local List Variable by index.
- `GetRotationDirectionLocalName`: Retrieves a direction vector from a Local Name Variable.

### Rotation Euler Retrieval Classes
- `GetRotationEulerGlobalList`: Returns Euler rotation values from a Global List Variable by index.
- `GetRotationEulerGlobalName`: Retrieves Euler rotation values from a Global Name Variable.
- `GetRotationEulerLocalList`: Fetches Euler rotation values from a Local List Variable by index.
- `GetRotationEulerLocalName`: Obtains Euler rotation values from a Local Name Variable.

## Usage Example
Here's an example demonstrating how to use the rotation retrieval classes:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class RotationManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetRotationDirectionGlobalList globalListDirectionGetter;
    private GetRotationEulerGlobalName globalNameEulerGetter;
    // Additional getters for local list and name would be defined similarly

    public Vector3 GetGlobalListDirection(int index)
    {
        // Retrieves direction vector from the specified index in the global list
        return globalListDirectionGetter.Get(index);
    }

    public Vector3 GetGlobalNameEulerRotation(string name)
    {
        // Retrieves Euler rotation values from a global name variable
        return globalNameEulerGetter.Get(name);
    }

    // Additional methods for local list and name rotation retrievals would follow a similar pattern
}
```

## Note
The `Get()` method shown in the examples is representative. Actual implementation details might differ, and these examples should be adapted according to the specific API of Game Creator 2 and your game's requirements.
