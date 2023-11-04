
# Game Creator Direction Retrieval Properties

## Overview
This set of classes provides the functionality for retrieving `Vector3` values, representing directions or points in space, from global and local variables in Game Creator 2.

## Class Summaries

### GetDirectionGlobalList
Retrieves the `Vector3` direction value from a Global List Variable, which can be used for things like setting the orientation of objects, navigation waypoints, or wind directions in a global context.

### GetDirectionGlobalName
Obtains the `Vector3` direction value from a Global Name Variable by a unique identifier, suitable for accessing and applying universal directional settings or 3D points.

### GetDirectionLocalList
Fetches the `Vector3` direction value from a Local List Variable, intended for local directional settings such as scene-specific orientations or movements.

### GetDirectionLocalName
Retrieves the `Vector3` direction value from a Local Name Variable, allowing for the management of direction or 3D point data within a local context or specific scene.

## Usage Example
Here's an example of how to use these classes in a game to work with directional data:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class DirectionManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetDirectionGlobalList getGlobalListDirection;
    private GetDirectionGlobalName getGlobalNameDirection;
    private GetDirectionLocalList getLocalListDirection;
    private GetDirectionLocalName getLocalNameDirection;

    public Vector3 GetGlobalWindDirection(int index)
    {
        // Retrieves a wind direction from the global list by index
        return getGlobalListDirection.Get(index);
    }

    public Vector3 GetSpawnPoint(string name)
    {
        // Retrieves a spawn point from the global variables by name
        return getGlobalNameDirection.Get(name);
    }

    // Similar methods would be implemented for local list and name direction retrievals
}
```

## Note
The `Get()` method in the example is abstract and may not directly correspond to the actual methods of the classes. The example serves to illustrate potential use cases and should be adapted to the specific mechanics of your game and the Game Creator 2 API.
