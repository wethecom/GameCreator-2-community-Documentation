
# Game Creator Color Properties

## Overview
`PropertySetColor` and `PropertyGetColor` are classes designed for managing color properties within Game Creator 2. They are used to set and retrieve `UnityEngine.Color` values in game development.

## `PropertySetColor` Usage
The `PropertySetColor` class is used to assign color values to properties.

### Initialization
```csharp
PropertySetColor setColor = new PropertySetColor();
```

### Setting a Color
Assuming a method `SetValue(Color value)` exists.
```csharp
setColor.SetValue(new Color(1f, 0f, 0f, 1f)); // Set the property to red
```

## `PropertyGetColor` Usage
The `PropertyGetColor` class is used to retrieve color values from properties.

### Initialization
```csharp
PropertyGetColor getColor = new PropertyGetColor();
```

### Retrieving a Color
Assuming a method `GetValue()` exists.
```csharp
Color color = getColor.GetValue(); // Retrieves the color value
```

## Example
The following example demonstrates how to change the color of a game object's material using `PropertySetColor` and `PropertyGetColor`.

```csharp
using GameCreator.Runtime.Common;
using UnityEngine;

public class MaterialColorController
{
    private PropertySetColor colorSetter;
    private Renderer renderer;

    public MaterialColorController(Renderer renderer)
    {
        this.colorSetter = new PropertySetColor();
        this.renderer = renderer;
    }

    public void ChangeColor(Color newColor)
    {
        // Set the new color using PropertySetColor
        this.colorSetter.SetValue(newColor);
        
        // Assuming the SetValue method applies the color to the target
        Color appliedColor = this.colorSetter.GetValue(); // Retrieve the set color
        
        // Apply the color to the renderer's material
        this.renderer.material.color = appliedColor;
    }
}
```
