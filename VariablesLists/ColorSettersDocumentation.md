
# Game Creator Color Setting Properties

## Overview
This set of classes is designed to assign `Color` values to both global and local variables in Game Creator 2, allowing for dynamic and responsive visual settings within the game.

## Class Summaries

### SetColorGlobalList
Assigns a `Color` value to a specified index within a Global List Variable. Useful for changing visual elements that are consistent throughout the game.

### SetColorGlobalName
Sets a `Color` value to a Global Variable identified by a unique name. Ideal for modifying game-wide color settings from various game logic points.

### SetColorLocalList
Assigns a `Color` value to a specified index within a Local List Variable. Suited for changing colors within a specific scene or segment of gameplay.

### SetColorLocalName
Sets a `Color` value to a Local Variable identified by a unique name. Utilized for managing color settings that are local to a scene or gameplay context.

## Usage Example
Here's a hypothetical example showing how to set color values for different purposes:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class ColorSetter
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private SetColorGlobalList setGlobalListColor;
    private SetColorGlobalName setGlobalNameColor;
    private SetColorLocalList setLocalListColor;
    private SetColorLocalName setLocalNameColor;

    public void ApplyThemeColor(int index, Color color)
    {
        // Sets a theme color in the global list
        setGlobalListColor.Set(index, color);
    }

    public void UpdateStatusColor(string name, Color color)
    {
        // Sets a status indicator color by name in global variables
        setGlobalNameColor.Set(name, color);
    }

    // Similar methods would be implemented for local list and name color settings
}
```

## Note
The `Set()` method in the example is abstract and may not directly correspond to the actual methods of the classes. The example serves to illustrate potential use cases and should be adapted to the specific mechanics of your game and the Game Creator 2 API.
