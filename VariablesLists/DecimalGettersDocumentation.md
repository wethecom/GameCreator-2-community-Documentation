
# Game Creator Decimal Retrieval Properties

## Overview
These classes provide mechanisms for retrieving decimal values and list lengths from global and local variables in Game Creator 2. They enable the precise handling of numerical data within your game's logic.

## Class Summaries

### GetDecimalGlobalList
Obtains a decimal value from a specific index within a Global List Variable, typically used for scoring systems, calculations, and other numerical data that are globally accessible.

### GetDecimalGlobalListLength
Fetches the count of elements within a Global List Variable, useful for loops, conditions, and dynamic list operations.

### GetDecimalGlobalName
Retrieves a decimal value from a Global Name Variable, offering a way to access unique global numerical settings or statuses by name.

### GetDecimalLocalList
Grabs a decimal value from a specific index within a Local List Variable, ideal for scene-specific numerical data or parameters.

### GetDecimalLocalListLength
Gets the count of elements within a Local List Variable, which can be used for local list management within a scene or module.

### GetDecimalLocalName
Retrieves a decimal value from a Local Name Variable, allowing for the manipulation of named local numerical data.

## Usage Example
Below is a conceptual example of how these classes could be integrated into a game to handle numerical data:

```csharp
using GameCreator.Runtime.Variables;

public class ScoreManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetDecimalGlobalList getGlobalListDecimal;
    private GetDecimalGlobalListLength getGlobalListLength;
    private GetDecimalGlobalName getGlobalNameDecimal;
    private GetDecimalLocalList getLocalListDecimal;
    private GetDecimalLocalListLength getLocalListLength;
    private GetDecimalLocalName getLocalNameDecimal;

    public decimal GetGlobalScore(int index)
    {
        // Retrieves a score from the global list by index
        return getGlobalListDecimal.Get(index);
    }

    public int GetGlobalScoresCount()
    {
        // Retrieves the total count of scores in the global list
        return (int)getGlobalListLength.Get();
    }

    // Similar methods would be implemented for local list and name decimal retrievals
}
```

## Note
The `Get()` method in the example is abstract and may differ from the actual methods provided by the classes. The example is intended to demonstrate potential use cases and should be adapted to the specific mechanics of your game and the Game Creator 2 API.
