
# Game Creator Boolean Setting Properties

## Overview
This collection of classes is designed for setting boolean values across various scopes and variable types in Game Creator 2. They enable precise control over boolean variables, facilitating complex game logic and state management.

## Class Summaries

### SetBoolGlobalList
Sets a boolean value at a specified index within a Global List Variable. Useful for managing game states that are accessible across different scenes or gameplay sessions.

### SetBoolGlobalName
Assigns a boolean value to a Global Variable identified by a unique name. Ideal for tracking game-wide flags and switches.

### SetBoolLocalList
Sets a boolean value at a specified index within a Local List Variable. This is for states that are confined to a particular scene or object.

### SetBoolLocalName
Assigns a boolean value to a Local Variable identified by a unique name. Used for localized game states that do not persist outside the current context.

## Usage Example
Below is a simplified example illustrating the use of these classes to set boolean states:

```csharp
using GameCreator.Runtime.Variables;

public class BooleanStateManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private SetBoolGlobalList setGlobalListBool;
    private SetBoolGlobalName setGlobalNameBool;
    private SetBoolLocalList setLocalListBool;
    private SetBoolLocalName setLocalNameBool;
    
    public void SetGlobalListFlag(int index, bool state)
    {
        // Sets the state of a global list variable at the specified index
        setGlobalListBool.Set(index, state);
    }

    public void SetGlobalNameFlag(string name, bool state)
    {
        // Sets the state of a global variable identified by name
        setGlobalNameBool.Set(name, state);
    }

    // Similar methods would be implemented for local list and name variables
}
```

## Note
The `Set()` method used in the example is conceptual and may not directly correspond to the actual method names in the classes. Adjustments should be made according to the actual class interfaces and game architecture.

