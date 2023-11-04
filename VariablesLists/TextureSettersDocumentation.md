
# Game Creator Texture Setting Properties

## Overview
This section outlines the classes used to set `Texture` assets to various types of variables in Game Creator 2. These properties enable the dynamic setting of textures, which can be applied to characters, environments, UI elements, and more within the game.

## Class Summaries

### Texture Setting Classes
- `SetTextureGlobalList`: Sets a `Texture` asset to a Global List Variable at a specified index.
- `SetTextureGlobalName`: Assigns a `Texture` asset to a Global Name Variable.
- `SetTextureLocalList`: Applies a `Texture` asset to a Local List Variable at a specified index.
- `SetTextureLocalName`: Sets a `Texture` asset to a Local Name Variable.

## Usage Example
The following example demonstrates how to use these classes to set textures within your game:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class TextureAssignmentManager
{
    // These variables should be initialized and set up in your game code
    private SetTextureGlobalList globalListTextureSetter;
    private SetTextureGlobalName globalNameTextureSetter;
    private SetTextureLocalList localListTextureSetter;
    private SetTextureLocalName localNameTextureSetter;

    public void SetGlobalListTexture(Texture texture, int index)
    {
        // Sets the texture at the specified index in the global list
        globalListTextureSetter.Set(texture, index);
    }

    public void SetGlobalNameTexture(Texture texture, string name)
    {
        // Assigns the texture to a global name variable
        globalNameTextureSetter.Set(texture, name);
    }

    public void SetLocalListTexture(Texture texture, int index)
    {
        // Sets the texture at the specified index in the local list
        localListTextureSetter.Set(texture, index);
    }

    public void SetLocalNameTexture(Texture texture, string name)
    {
        // Sets the texture to a local name variable
        localNameTextureSetter.Set(texture, name);
    }
}
```

## Note
The `Set()` methods described above are conceptual. The actual implementation may differ depending on Game Creator 2's API and the specific needs of your game project.
