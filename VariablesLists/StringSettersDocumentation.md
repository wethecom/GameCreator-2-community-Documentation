
# Game Creator String Setting Properties

## Overview
This section of the documentation describes the classes used for setting `string` values to various variables in Game Creator 2. These classes facilitate dynamic text manipulation within the game, which can be applied to game settings, character dialogue, UI elements, and more.

## Class Summaries

### String Setting Classes
- `SetStringGlobalList`: Sets a `string` to a Global List Variable at a specified index.
- `SetStringGlobalName`: Assigns a `string` to a Global Name Variable.
- `SetStringLocalList`: Applies a `string` to a Local List Variable at a specified index.
- `SetStringLocalName`: Sets a `string` to a Local Name Variable.

## Usage Example
The following is an illustrative example of how to use these classes within your game:

```csharp
using GameCreator.Runtime.Variables;
using UnityEngine;

public class DialogueManager
{
    // These variables should be initialized and set up in your game code
    private SetStringGlobalList globalListStringSetter;
    private SetStringGlobalName globalNameStringSetter;
    private SetStringLocalList localListStringSetter;
    private SetStringLocalName localNameStringSetter;

    public void SetGlobalListString(string text, int index)
    {
        // Sets the string at the specified index in the global list
        globalListStringSetter.Set(text, index);
    }

    public void SetGlobalNameString(string text, string name)
    {
        // Assigns the string to a global name variable
        globalNameStringSetter.Set(text, name);
    }

    public void SetLocalListString(string text, int index)
    {
        // Sets the string at the specified index in the local list
        localListStringSetter.Set(text, index);
    }

    public void SetLocalNameString(string text, string name)
    {
        // Sets the string to a local name variable
        localNameStringSetter.Set(text, name);
    }
}
```

## Note
The `Set()` methods depicted above are for demonstration purposes only. The actual code should be adapted to the specific APIs provided by Game Creator 2 and the requirements of your particular project.
