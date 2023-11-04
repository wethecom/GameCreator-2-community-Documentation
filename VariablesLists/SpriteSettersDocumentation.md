
# Game Creator Sprite Setting Properties

## Overview
This documentation covers the classes that set `Sprite` values to various variables in Game Creator 2. These properties enable developers to dynamically change sprites, which can be useful for updating UI elements, character icons, or other sprite-based visuals in the game.

## Class Summaries

### Sprite Setting Classes
- `SetSpriteGlobalList`: Sets a `Sprite` to a Global List Variable at a specified index.
- `SetSpriteGlobalName`: Sets a `Sprite` to a Global Name Variable.
- `SetSpriteLocalList`: Sets a `Sprite` to a Local List Variable at a specified index.
- `SetSpriteLocalName`: Sets a `Sprite` to a Local Name Variable.

## Usage Example
The following is an example demonstrating how to use these classes to set sprites:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class SpriteChanger
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private SetSpriteGlobalList globalListSpriteSetter;
    private SetSpriteGlobalName globalNameSpriteSetter;
    private SetSpriteLocalList localListSpriteSetter;
    private SetSpriteLocalName localNameSpriteSetter;

    public void SetGlobalListSprite(Sprite sprite, int index)
    {
        // Sets the Sprite to the specified index in the global list
        globalListSpriteSetter.Set(sprite, index);
    }

    public void SetGlobalNameSprite(Sprite sprite, string name)
    {
        // Sets the Sprite to a global name variable
        globalNameSpriteSetter.Set(sprite, name);
    }

    public void SetLocalListSprite(Sprite sprite, int index)
    {
        // Sets the Sprite to the specified index in the local list
        localListSpriteSetter.Set(sprite, index);
    }

    public void SetLocalNameSprite(Sprite sprite, string name)
    {
        // Sets the Sprite to a local name variable
        localNameSpriteSetter.Set(sprite, name);
    }
}
```

## Note
The `Set()` method shown in the examples is representative. Actual implementation details may vary, and the examples should be adapted to fit the specific API of Game Creator 2 and the needs of your game project.
