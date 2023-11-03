
# Game Creator GameObject Properties

## Overview
`PropertySetGameObject` and `PropertyGetGameObject` are classes designed for managing GameObject references in Game Creator 2. They provide methods to set and retrieve `UnityEngine.GameObject` values and their components within the game environment.

## `PropertySetGameObject` Usage
The `PropertySetGameObject` class assigns GameObject references.

### Initialization
```csharp
PropertySetGameObject setGameObject = new PropertySetGameObject();
```

### Setting a GameObject
Assuming a method `SetValue(GameObject value)` exists.
```csharp
GameObject myGameObject; // Assume this is already initialized
setGameObject.SetValue(myGameObject); // Assign the GameObject reference
```

## `PropertyGetGameObject` Usage
The `PropertyGetGameObject` class retrieves GameObject references and their components.

### Initialization
```csharp
PropertyGetGameObject getGameObject = new PropertyGetGameObject();
```

### Retrieving a GameObject or Component
Assuming methods `GetValue()` and `Get<T>(Args args)` exist.
```csharp
GameObject gameObject = getGameObject.GetValue(); // Retrieves the GameObject reference
MyComponent component = getGameObject.Get<MyComponent>(new Args()); // Retrieves a specific component
```

## Example
Below is an example demonstrating how to enable a component on a GameObject using `PropertySetGameObject` and `PropertyGetGameObject`.

```csharp
using GameCreator.Runtime.Common;
using UnityEngine;

public class ComponentEnabler
{
    private PropertyGetGameObject gameObjectGetter;

    public ComponentEnabler()
    {
        this.gameObjectGetter = new PropertyGetGameObject();
    }

    public void EnableComponent<T>(Args args) where T : Behaviour
    {
        T component = this.gameObjectGetter.Get<T>(args);
        if (component != null)
        {
            component.enabled = true;
        }
    }
}
```
