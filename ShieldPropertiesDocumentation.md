
# Game Creator Shield Properties

## Overview
`PropertySetShield` and `PropertyGetShield` are classes used for managing shield properties in Game Creator 2. They provide interfaces to set and retrieve shield values, which are part of the character or object properties within a game.

## `PropertySetShield` Usage
This class is used to set shield properties on characters or objects.

### Initialization
```csharp
PropertySetShield setShield = new PropertySetShield();
```

### Setting a Shield Value
Assuming a method `SetValue(IShield value)` exists.
```csharp
IShield myShield; // Assume this is an interface implemented by your shield system
setShield.SetValue(myShield); // Set the shield property
```

## `PropertyGetShield` Usage
The `PropertyGetShield` class is used to retrieve shield properties.

### Initialization
```csharp
PropertyGetShield getShield = new PropertyGetShield();
```

### Retrieving a Shield Value
Assuming a method `GetValue()` exists.
```csharp
IShield shield = getShield.GetValue(); // Retrieves the shield property
```

## Example
Below is an example of how to integrate the shield properties with a character in the game.

```csharp
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Characters;

public class CharacterShieldManager
{
    private PropertySetShield shieldSetter;
    private PropertyGetShield shieldGetter;

    public CharacterShieldManager()
    {
        this.shieldSetter = new PropertySetShield();
        this.shieldGetter = new PropertyGetShield();
    }

    public void AssignShield(IShield shield)
    {
        this.shieldSetter.SetValue(shield); // Assign the shield to the character
    }

    public IShield RetrieveShield()
    {
        return this.shieldGetter.GetValue(); // Retrieve the shield from the character
    }
}
```
