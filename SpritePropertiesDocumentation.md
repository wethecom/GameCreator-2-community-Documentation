
# Game Creator Sprite Properties

## Overview
`PropertySetSprite` and `PropertyGetSprite` are classes for managing sprite properties within Game Creator 2. These classes are used to set and retrieve `UnityEngine.Sprite` objects, typically for use with 2D game elements.

## `PropertySetSprite` Usage
This class sets sprite properties to a game object or component.

### Initialization
```csharp
PropertySetSprite setSprite = new PropertySetSprite();
```

### Setting a Sprite
Assuming a method `SetValue(Sprite value)` exists.
```csharp
Sprite mySprite; // Assume this is already initialized
setSprite.SetValue(mySprite); // Assigns the sprite
```

## `PropertyGetSprite` Usage
The `PropertyGetSprite` class retrieves sprite properties.

### Initialization
```csharp
PropertyGetSprite getSprite = new PropertyGetSprite();
```

### Retrieving a Sprite
Assuming a method `GetValue()` exists.
```csharp
Sprite sprite = getSprite.GetValue(); // Retrieves the sprite
```

## Example
Here's an example of how to change the sprite of a UI image component using `PropertySetSprite` and `PropertyGetSprite`.

```csharp
using GameCreator.Runtime.Common;
using UnityEngine;
using UnityEngine.UI;

public class ImageSpriteChanger
{
    private PropertySetSprite spriteSetter;
    private Image imageComponent;

    public ImageSpriteChanger(Image image)
    {
        this.spriteSetter = new PropertySetSprite();
        this.imageComponent = image;
    }

    public void ChangeSprite(Sprite newSprite)
    {
        // Set the new sprite using PropertySetSprite
        this.spriteSetter.SetValue(newSprite);
        
        // Assuming the SetValue method updates the sprite of the target
        Sprite updatedSprite = this.spriteSetter.GetValue(); // Retrieve the set sprite
        
        // Apply the sprite to the image component
        this.imageComponent.sprite = updatedSprite;
    }
}
```
