
# Game Creator Number Setting Properties

## Overview
This set of classes allows for the setting of numerical values to global and local variables in Game Creator 2, which can be used for scoring, calculations, and configuration settings within the game.

## Class Summaries

### SetNumberGlobalList
Assigns a numerical value to a specified index within a Global List Variable, commonly used for modifying scoreboards, game metrics, or global settings that are list-based.

### SetNumberGlobalName
Sets a numerical value to a Global Variable identified by a unique name, which is useful for updating game-wide numerical settings or parameters by referencing them directly by name.

### SetNumberLocalList
Assigns a numerical value to a specified index within a Local List Variable, ideal for scene-specific numerical adjustments or parameters that are list-based.

### SetNumberLocalName
Sets a numerical value to a Local Variable identified by a unique name, used for changing numerical settings that are local to a specific scene or module.

## Usage Example
The following hypothetical example demonstrates how these classes can be utilized to manage numerical values in a game:

```csharp
using GameCreator.Runtime.Variables;

public class GameManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private SetNumberGlobalList setGlobalListNumber;
    private SetNumberGlobalName setGlobalNameNumber;
    private SetNumberLocalList setLocalListNumber;
    private SetNumberLocalName setLocalNameNumber;

    public void UpdateGlobalScore(int index, double score)
    {
        // Updates a score value in the global list at the specified index
        setGlobalListNumber.Set(index, score);
    }

    public void SetGlobalTemperature(string name, double temperature)
    {
        // Sets a global temperature value by name
        setGlobalNameNumber.Set(name, temperature);
    }

    // Similar methods would be implemented for local list and name number settings
}
```

## Note
The `Set()` method in the example is abstract and may not directly correspond to the actual methods of the classes. The example is intended to illustrate potential use cases and should be adapted to the specific mechanics of your game and the Game Creator 2 API.
