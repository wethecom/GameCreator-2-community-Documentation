The `PropertySetBool` and `PropertyGetBool` classes with usage examples, all in a concise and straightforward format.

Here's the complete Markdown content:

```markdown
# Game Creator Boolean Properties

## Overview
`PropertySetBool` and `PropertyGetBool` are utility classes for setting and getting boolean values in Game Creator 2. They provide a standardized approach for boolean property management within the game development environment.

## Installation
Ensure the Game Creator Runtime Common library is part of your Unity project. Import the classes as needed.

## `PropertySetBool` Usage
The `PropertySetBool` class is used to assign boolean values.

### Initialization
```csharp
PropertySetBool setBool = new PropertySetBool();
```

### Setting a Value
Assuming a method `SetValue(bool value)` exists.
```csharp
setBool.SetValue(true); // Set the property to true
```

## `PropertyGetBool` Usage
The `PropertyGetBool` class is responsible for retrieving boolean values.

### Initialization
```csharp
PropertyGetBool getBool = new PropertyGetBool();
```

### Retrieving a Value
Assuming a method `GetValue()` exists.
```csharp
bool value = getBool.GetValue(); // Retrieves the boolean value
```

## Example
Here's an example of how to toggle a game object's active state using `PropertySetBool` and `PropertyGetBool`.

```csharp
using GameCreator.Runtime.Common;

public class ActiveStateController
{
    private PropertySetBool setActive;
    private PropertyGetBool getActive;

    public ActiveStateController()
    {
        this.setActive = new PropertySetBool();
        this.getActive = new PropertyGetBool();
    }

    public void ToggleActiveState()
    {
        bool currentState = this.getActive.GetValue();
        this.setActive.SetValue(!currentState);
    }
}
```
```

