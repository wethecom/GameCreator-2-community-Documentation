
# Game Creator Color Retrieval Properties

## Overview
This suite of classes is intended for obtaining `Color` values from global and local variables within Game Creator 2, enabling dynamic visual effects and UI elements that respond to game logic.

## Class Summaries

### GetColorGlobalList
Fetches the `Color` value from a specified index within a Global List Variable. This is particularly useful for setting UI themes or object colors that are consistent across the entire game.

### GetColorGlobalName
Retrieves the `Color` value from a Global Variable identified by a unique name. Ideal for game-wide color settings that need to be accessed or modified from various points in the game.

### GetColorLocalList
Fetches the `Color` value from a specified index within a Local List Variable. Suited for managing colors that are specific to certain scenes or gameplay segments.

### GetColorLocalName
Retrieves the `Color` value from a Local Variable identified by a unique name. Used for localized color properties that change within the confines of a particular scene or context.

## Usage Example
Here's a conceptual example demonstrating the retrieval of color values for various purposes:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class ColorManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetColorGlobalList getGlobalListColor;
    private GetColorGlobalName getGlobalNameColor;
    private GetColorLocalList getLocalListColor;
    private GetColorLocalName getLocalNameColor;

    public Color GetThemeColor(int index)
    {
        // Retrieves a theme color from the global list
        return getGlobalListColor.Get(index);
    }

    public Color GetStatusColor(string name)
    {
        // Retrieves a status indicator color by name from global variables
        return getGlobalNameColor.Get(name);
    }

    // Similar methods would be implemented for local list and name color values
}
```

## Note
The `Get()` method in the example is abstract and may differ from the actual methods provided by the classes. The example is intended to inspire potential use cases and should be adapted to your game's specific mechanics and the Game Creator 2 API.
