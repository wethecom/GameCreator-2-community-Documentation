
# Game Creator Texture Properties

## Overview
`PropertySetTexture` and `PropertyGetTexture` are classes used for managing texture properties within Game Creator 2. These classes provide the functionality to set and retrieve `UnityEngine.Texture` objects, which are often used for applying textures to materials or UI elements in games.

## `PropertySetTexture` Usage
This class sets texture properties for game objects or components.

### Initialization
```csharp
PropertySetTexture setTexture = new PropertySetTexture();
```

### Setting a Texture
Assuming a method `SetValue(Texture value)` exists within the class.
```csharp
Texture myTexture; // Assume this is already initialized
setTexture.SetValue(myTexture); // Sets the texture property
```

## `PropertyGetTexture` Usage
The `PropertyGetTexture` class retrieves texture properties.

### Initialization
```csharp
PropertyGetTexture getTexture = new PropertyGetTexture();
```

### Retrieving a Texture
Assuming a method `GetValue()` exists within the class.
```csharp
Texture texture = getTexture.GetValue(); // Retrieves the texture property
```

## Example
Here's an example of how to set and get the texture of a material using `PropertySetTexture` and `PropertyGetTexture`.

```csharp
using GameCreator.Runtime.Common;
using UnityEngine;

public class MaterialTextureManager
{
    private PropertySetTexture textureSetter;
    private PropertyGetTexture textureGetter;
    private Material targetMaterial;

    public MaterialTextureManager(Material material)
    {
        this.textureSetter = new PropertySetTexture();
        this.textureGetter = new PropertyGetTexture();
        this.targetMaterial = material;
    }

    public void ApplyTexture(Texture newTexture)
    {
        // Set the new texture using PropertySetTexture
        this.textureSetter.SetValue(newTexture);
        
        // Retrieve and apply the texture to the material
        this.targetMaterial.mainTexture = this.textureGetter.GetValue();
    }
}
```
