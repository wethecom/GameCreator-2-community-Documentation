
# Game Creator Boolean Retrieval Properties

## Overview
This set of classes provides various ways to retrieve boolean values from global and local variables within Game Creator 2. Each class is designed for a specific retrieval purpose, ensuring flexibility and precision when working with boolean variables in your game logic.

## Class Summaries

### GetBoolGlobalList
Retrieves the boolean value from a specified index of a Global List Variable.

### GetBoolGlobalListAny
Checks if any element within a Global List Variable is set to `true`.

### GetBoolGlobalListEmpty
Checks if a Global List Variable is empty (no elements are set to `true`).

### GetBoolGlobalName
Retrieves the boolean value of a Global Variable identified by a unique name.

### GetBoolLocalList
Retrieves the boolean value from a specified index of a Local List Variable.

### GetBoolLocalListAny
Checks if any element within a Local List Variable is set to `true`.

### GetBoolLocalListEmpty
Checks if a Local List Variable is empty (no elements are set to `true`).

### GetBoolLocalName
Retrieves the boolean value of a Local Variable identified by a unique name.

## Usage Example
Below is a hypothetical example of how these classes could be used to manage game states:

```csharp
using GameCreator.Runtime.Variables;

public class GameStateManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetBoolGlobalList getGlobalListBool;
    private GetBoolGlobalListAny getGlobalListAnyBool;
    private GetBoolGlobalListEmpty getGlobalListEmptyBool;
    private GetBoolGlobalName getGlobalNameBool;
    private GetBoolLocalList getLocalListBool;
    private GetBoolLocalListAny getLocalListAnyBool;
    private GetBoolLocalListEmpty getLocalListEmptyBool;
    private GetBoolLocalName getLocalNameBool;
    
    public bool CheckGlobalConditions()
    {
        // Checks if any condition in the global list is true
        return getGlobalListAnyBool.Check();
    }

    public bool IsGlobalListEmpty()
    {
        // Checks if the global list has no true values
        return getGlobalListEmptyBool.Check();
    }

    public bool GetGlobalFlag(string name)
    {
        // Retrieves the value of a global flag by name
        return getGlobalNameBool.Get(name);
    }

    // Similar methods would be implemented for local list and name variables
}
```

## Note
The actual implementation of the methods `Check()` and `Get()` will vary depending on how boolean values are stored and managed in the game. The example provided is a general guide and should be adapted to fit the specific mechanics of your game.

