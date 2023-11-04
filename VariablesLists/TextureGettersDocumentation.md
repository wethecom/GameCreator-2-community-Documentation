
# Game Creator Texture Retrieval Properties

## Overview
This part of the documentation provides information on the classes used to retrieve `Texture` assets from various types of variables in Game Creator 2. These properties allow for dynamic texture management, which can be applied to character skins, environment textures, UI elements, and more within the game.

## Class Summaries

### Texture Retrieval Classes
- `GetTextureGlobalList`: Retrieves a `Texture` from a Global List Variable by index.
- `GetTextureGlobalName`: Obtains a `Texture` from a Global Name Variable.
- `GetTextureLocalList`: Fetches a `Texture` from a Local List Variable by index.
- `GetTextureLocalName`: Retrieves a `Texture` from a Local Name Variable.

## Usage Example
Below is a hypothetical example showcasing how you might use these classes:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class TextureManager
{
    // Assume these variables are initialized and set up elsewhere in the game
    private GetTextureGlobalList globalListTextureGetter;
    private GetTextureGlobalName globalNameTextureGetter;
    private GetTextureLocalList localListTextureGetter;
    private GetTextureLocalName localNameTextureGetter;

    public Texture GetGlobalListTexture(int index)
    {
        // Retrieves the texture from the specified index in the global list
        return globalListTextureGetter.Get(index);
    }

    public Texture GetGlobalNameTexture(string name)
    {
        // Retrieves the texture from a global name variable
        return globalNameTextureGetter.Get(name);
    }

    public Texture GetLocalListTexture(int index)
    {
        // Retrieves the texture from the specified index in the local list
        return localListTextureGetter.Get(index);
    }

    public Texture GetLocalNameTexture(string name)
    {
        // Retrieves the texture from a local name variable
        return localNameTextureGetter.Get(name);
    }
}
```

## Note
The `Get()` method used in the examples is for illustrative purposes. Actual implementations may vary based on Game Creator 2's API and the specific needs of your game project.
