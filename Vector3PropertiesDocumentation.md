
# Game Creator Vector3 Properties

## Overview
`PropertySetVector3` is a class used for setting `Vector3` properties in Game Creator 2. The `Vector3` class is a part of the Unity Engine and represents three-dimensional vectors and points, which are widely used in 3D game development for positions, directions, and scales.

## `PropertySetVector3` Usage
This class allows you to assign `Vector3` values to game objects, components, or other game elements that can interpret `Vector3` data.

### Initialization
```csharp
PropertySetVector3 setVector3 = new PropertySetVector3();
```

### Setting a Vector3 Value
Assuming a method `SetValue(Vector3 value)` exists.
```csharp
Vector3 position = new Vector3(0, 1, 0); // Create a new Vector3 for position
setVector3.SetValue(position); // Sets the Vector3 property
```

## Example
Here's an example of how to set the position of a GameObject using `PropertySetVector3`.

```csharp
using GameCreator.Runtime.Common;
using UnityEngine;

public class ObjectPositionManager
{
    private PropertySetVector3 positionSetter;
    private GameObject targetObject;

    public ObjectPositionManager(GameObject target)
    {
        this.positionSetter = new PropertySetVector3();
        this.targetObject = target;
    }

    public void SetPosition(Vector3 newPosition)
    {
        // Set the new position using PropertySetVector3
        this.positionSetter.SetValue(newPosition);
        
        // Apply the Vector3 to the GameObject's position
        this.targetObject.transform.position = newPosition;
    }
}
```
