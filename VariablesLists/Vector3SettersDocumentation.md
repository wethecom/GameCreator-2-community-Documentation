
# Game Creator Vector3 Setting Properties

## Overview
This documentation section describes classes used to set `Vector3` values for various types of variables in Game Creator 2. This functionality is pivotal for manipulating object positions, rotations, and scales within the game's 3D space.

## Class Summaries

### Vector3 Setting Classes
- `SetVector3GlobalList`: Assigns a `Vector3` value to a Global List Variable at a specified index.
- `SetVector3GlobalName`: Sets a `Vector3` value to a Global Name Variable.
- `SetVector3LocalList`: Applies a `Vector3` value to a Local List Variable at a specified index.
- `SetVector3LocalName`: Assigns a `Vector3` value to a Local Name Variable.

## Usage Example
Here's an example to illustrate how you might use these classes in a game:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class Vector3Manager
{
    // Assume these variables are initialized elsewhere in your game
    private SetVector3GlobalList globalListVectorSetter;
    private SetVector3GlobalName globalNameVectorSetter;
    private SetVector3LocalList localListVectorSetter;
    private SetVector3LocalName localNameVectorSetter;

    public void SetGlobalListVector(Vector3 value, int index)
    {
        // Sets the Vector3 value at the specified index in the global list
        globalListVectorSetter.Set(value, index);
    }

    public void SetGlobalNameVector(Vector3 value, string name)
    {
        // Sets the Vector3 value for a global name variable
        globalNameVectorSetter.Set(value, name);
    }

    public void SetLocalListVector(Vector3 value, int index)
    {
        // Sets the Vector3 value at the specified index in the local list
        localListVectorSetter.Set(value, index);
    }

    public void SetLocalNameVector(Vector3 value, string name)
    {
        // Sets the Vector3 value for a local name variable
        localNameVectorSetter.Set(value, name);
    }
}
```

## Note
The `Set()` methods used in the above examples are intended for conceptual understanding. Actual usage may vary based on the specific APIs provided by Game Creator 2 and the requirements of your project.
