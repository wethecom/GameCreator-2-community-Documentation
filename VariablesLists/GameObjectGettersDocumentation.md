
# Game Creator GameObject Retrieval Properties

## Overview
These classes facilitate the retrieval of `GameObject` references from various types of variables in Game Creator 2, enabling dynamic access to game objects within both global and local scopes.

## Class Summaries

### GetGameObjectGlobalList
Retrieves a `GameObject` from a specified index within a Global List Variable, which can be utilized for accessing and manipulating game objects that are part of a global collection.

### GetGameObjectGlobalName
Obtains a `GameObject` associated with a Global Name Variable, useful for interacting with globally identified game objects like "MainCharacter" or "MainCamera".

### GetGameObjectLocalList
Fetches a `GameObject` from a specified index within a Local List Variable, intended for retrieving game objects that are part of a local collection, such as items within a specific scene.

### GetGameObjectLocalName
Retrieves a `GameObject` associated with a Local Name Variable, allowing for the interaction with game objects that have a local identifier within the current scene or context.

## Usage Example
Here's a hypothetical example to demonstrate the use of these classes:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class GameObjectRetrievalExample
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetGameObjectGlobalList getGlobalListGameObject;
    private GetGameObjectGlobalName getGlobalNameGameObject;
    private GetGameObjectLocalList getLocalListGameObject;
    private GetGameObjectLocalName getLocalNameGameObject;

    public GameObject GetGlobalListItem(int index)
    {
        // Retrieves a game object from the global list at the specified index
        return getGlobalListGameObject.Get(index);
    }

    public GameObject GetGlobalNamedObject(string name)
    {
        // Retrieves a game object from the global variables by name
        return getGlobalNameGameObject.Get(name);
    }

    // Similar methods would be implemented for local list and name game object retrievals
}
```

## Note
The `Get()` method in the example is abstract and may vary from the actual methods provided by the classes. The example is conceptual and should be adapted to your game's specific mechanics and the Game Creator 2 API.
