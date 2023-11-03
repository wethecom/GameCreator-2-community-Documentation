
# Game Creator String Properties

## Overview
`PropertySetString` and `PropertyGetString` are classes used for managing string properties within Game Creator 2. These classes enable the setting and retrieval of string values, which can be used for various purposes like displaying text, saving game states, or other string-related operations in games.

## `PropertySetString` Usage
This class is used to set string properties to a game object, component, or other game elements.

### Initialization
```csharp
PropertySetString setString = new PropertySetString();
```

### Setting a String Value
Assuming a method `SetValue(string value)` exists.
```csharp
string message = "Hello, World!";
setString.SetValue(message); // Sets the string property
```

## `PropertyGetString` Usage
The `PropertyGetString` class is used to retrieve string properties.

### Initialization
```csharp
PropertyGetString getString = new PropertyGetString();
```

### Retrieving a String
Assuming a method `GetValue()` exists.
```csharp
string value = getString.GetValue(); // Retrieves the string property
```

## Example
Here's an example of how to use `PropertySetString` and `PropertyGetString` to manage the text of a UI Text element.

```csharp
using GameCreator.Runtime.Common;
using UnityEngine.UI;

public class TextManager
{
    private PropertySetString textSetter;
    private PropertyGetString textGetter;
    private Text uiTextComponent;

    public TextManager(Text uiText)
    {
        this.textSetter = new PropertySetString();
        this.textGetter = new PropertyGetString();
        this.uiTextComponent = uiText;
    }

    public void UpdateText(string newText)
    {
        // Set the new text
        this.textSetter.SetValue(newText);
        
        // Retrieve and update the UI Text component with the new value
        this.uiTextComponent.text = this.textGetter.GetValue();
    }
}
```
