
# Game Creator Sprite Retrieval Properties

## Overview
This documentation outlines classes that facilitate retrieving `Sprite` assets from various variables in Game Creator 2. These properties are useful for games that require dynamic sprite management, such as changing character icons, UI elements, or environmental textures.

## Class Summaries

### Sprite Retrieval Classes
- `GetSpriteGlobalList`: Retrieves a `Sprite` from a Global List Variable by index.
- `GetSpriteGlobalName`: Obtains a `Sprite` from a Global Name Variable.
- `GetSpriteLocalList`: Fetches a `Sprite` from a Local List Variable by index.
- `GetSpriteLocalName`: Retrieves a `Sprite` from a Local Name Variable.

## Usage Example
Here is an illustrative example of how these classes could be used within a game:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class SpriteManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetSpriteGlobalList globalListSpriteGetter;
    private GetSpriteGlobalName globalNameSpriteGetter;
    private GetSpriteLocalList localListSpriteGetter;
    private GetSpriteLocalName localNameSpriteGetter;

    public Sprite GetGlobalListSprite(int index)
    {
        // Retrieves Sprite from the specified index in the global list
        return globalListSpriteGetter.Get(index);
    }

    public Sprite GetGlobalNameSprite(string name)
    {
        // Retrieves Sprite from a global name variable
        return globalNameSpriteGetter.Get(name);
    }

    public Sprite GetLocalListSprite(int index)
    {
        // Retrieves Sprite from the specified index in the local list
        return localListSpriteGetter.Get(index);
    }

    public Sprite GetLocalNameSprite(string name)
    {
        // Retrieves Sprite from a local name variable
        return localNameSpriteGetter.Get(name);
    }
}
```

## Note
The `Get()` method exemplified in the usage is indicative. Actual implementation details may vary, and the examples should be adapted to fit the specific API of Game Creator 2 and the needs of your game project.
