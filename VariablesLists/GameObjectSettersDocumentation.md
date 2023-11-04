
# Game Creator GameObject Setting Properties

## Overview
These classes are designed to set `GameObject` references to various types of variables in Game Creator 2, allowing for dynamic management of game objects within both global and local scopes.

## Class Summaries

### SetGameObjectGlobalList
Sets a `GameObject` to a specified index within a Global List Variable, useful for dynamically changing game objects in a global context, like switching assets for characters or items.

### SetGameObjectGlobalName
Assigns a `GameObject` to a Global Variable identified by a name, ideal for globally changing game objects that are associated with specific names, such as "Player" or "MainCamera".

### SetGameObjectLocalList
Sets a `GameObject` to a specified index within a Local List Variable, intended for local context management, like changing the items in a scene's inventory or altering environment objects.

### SetGameObjectLocalName
Assigns a `GameObject` to a Local Variable identified by a name, suitable for scene-specific game object assignments, such as setting the current interactive item or local player avatar.

## Usage Example
Here is a simplified example to illustrate the use of these classes:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class GameObjectManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private SetGameObjectGlobalList setGlobalListGameObject;
    private SetGameObjectGlobalName setGlobalNameGameObject;
    private SetGameObjectLocalList setLocalListGameObject;
    private SetGameObjectLocalName setLocalNameGameObject;

    public void AssignToGlobalList(int index, GameObject obj)
    {
        // Assigns a game object to the global list at the specified index
        setGlobalListGameObject.Set(index, obj);
    }

    public void AssignGlobalName(string name, GameObject obj)
    {
        // Assigns a game object to the global variable with the specified name
        setGlobalNameGameObject.Set(name, obj);
    }

    // Similar methods would be implemented for local list and name game object settings
}
```

## Note
The `Set()` method in the example is abstract and may vary from the actual methods provided by the classes. The example is conceptual and should be adapted to your game's specific mechanics and the Game Creator 2 API.
