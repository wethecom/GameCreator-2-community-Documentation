
# Game Creator Location Retrieval Properties

## Overview
This set of classes provides the functionality to retrieve location data, either as `GameObject` references or `Vector3` coordinates, from different types of variables in Game Creator 2. They are essential for games that require dynamic access to objects and their positions within both global and local contexts.

## Class Summaries

### Object Location Retrievers
- `GetLocationObjectGlobalList`: Retrieves a `GameObject` from a Global List Variable based on index.
- `GetLocationObjectGlobalName`: Obtains a `GameObject` from a Global Name Variable.
- `GetLocationObjectLocalList`: Fetches a `GameObject` from a Local List Variable based on index.
- `GetLocationObjectLocalName`: Retrieves a `GameObject` from a Local Name Variable.

### Vector3 Location Retrievers
- `GetLocationVector3GlobalList`: Returns a `Vector3` position from a Global List Variable.
- `GetLocationVector3GlobalName`: Retrieves a `Vector3` position from a Global Name Variable.
- `GetLocationVector3LocalList`: Fetches a `Vector3` position from a Local List Variable.
- `GetLocationVector3LocalName`: Retrieves a `Vector3` position from a Local Name Variable.

## Usage Example
Below is a conceptual example to demonstrate the use of these classes:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class LocationManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetLocationObjectGlobalList globalListLocationGetter;
    private GetLocationVector3GlobalName globalNameVector3Getter;
    // Other retrievers would also be defined here

    public GameObject GetObjectFromGlobalList(int index)
    {
        // Retrieves a GameObject from the specified index in the global list
        return globalListLocationGetter.Get(index);
    }

    public Vector3 GetPositionFromGlobalName(string name)
    {
        // Retrieves the position Vector3 from a global name variable
        return globalNameVector3Getter.Get(name);
    }

    // Additional methods for local list and name retrievals would be similar
}
```

## Note
The `Get()` method used in the examples above is representative and might differ in actual implementation. The examples provided should be adapted according to the specific API of Game Creator 2 and the needs of your game.
