
# Game Creator Weapon Properties

## Overview
`PropertySetWeapon` and `PropertyGetWeapon` are classes designed for managing weapon properties within Game Creator 2. They allow the setting and retrieval of `IWeapon` instances, which are interfaces representing weapon elements in games.

## `PropertySetWeapon` Usage
This class is used to assign weapon properties to characters or other entities capable of wielding weapons.

### Initialization
```csharp
PropertySetWeapon setWeapon = new PropertySetWeapon();
```

### Setting a Weapon
Assuming a method `SetValue(IWeapon value)` exists within the class.
```csharp
IWeapon weapon; // Assume this is already initialized
setWeapon.SetValue(weapon); // Assigns the weapon property
```

## `PropertyGetWeapon` Usage
The `PropertyGetWeapon` class is employed to retrieve weapon properties from entities.

### Initialization
```csharp
PropertyGetWeapon getWeapon = new PropertyGetWeapon();
```

### Retrieving a Weapon
Assuming a method `GetValue()` exists within the class.
```csharp
IWeapon weapon = getWeapon.GetValue(); // Retrieves the weapon property
```

## Example
Here's an example of how to equip and retrieve a weapon for a character using `PropertySetWeapon` and `PropertyGetWeapon`.

```csharp
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Characters;

public class WeaponManager
{
    private PropertySetWeapon weaponSetter;
    private PropertyGetWeapon weaponGetter;
    private Character targetCharacter;

    public WeaponManager(Character character)
    {
        this.weaponSetter = new PropertySetWeapon();
        this.weaponGetter = new PropertyGetWeapon();
        this.targetCharacter = character;
    }

    public void EquipWeapon(IWeapon newWeapon)
    {
        // Equip the character with the new weapon using PropertySetWeapon
        this.weaponSetter.SetValue(newWeapon);
        
        // Retrieve the equipped weapon (if needed)
        IWeapon equippedWeapon = this.weaponGetter.GetValue();
        
        // Additional logic to handle the equipped weapon can be added here
    }
}
```
