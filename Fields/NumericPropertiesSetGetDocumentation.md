
# Game Creator Numeric Properties

## Overview
`PropertySetNumber`, `PropertyGetDecimal`, and `PropertyGetInteger` are classes provided by the Game Creator Runtime Common library. They facilitate the setting and getting of numeric values within a game's logic.

## `PropertySetNumber` Usage
Sets numeric values, specifically doubles.

### Initialization
```csharp
PropertySetNumber setNumber = new PropertySetNumber();
```

### Setting a Value
Assuming a method `SetValue(double value)` exists.
```csharp
setNumber.SetValue(10.5); // Set the property to 10.5
```

## `PropertyGetDecimal` Usage
Gets numeric values as doubles.

### Initialization
```csharp
PropertyGetDecimal getDecimal = new PropertyGetDecimal();
```

### Retrieving a Value
Assuming a method `GetValue()` exists.
```csharp
double decimalValue = getDecimal.GetValue(); // Retrieves the decimal value
```

## `PropertyGetInteger` Usage
Gets integer values and returns them as doubles.

### Initialization
```csharp
PropertyGetInteger getInteger = new PropertyGetInteger();
```

### Retrieving a Value
Assuming a method `GetValue()` exists.
```csharp
double integerValue = getInteger.Get(new Args()); // Retrieves the integer value
```

## Example
Here's an example of how to use these classes to control a score system in a game.

```csharp
using GameCreator.Runtime.Common;

public class ScoreController
{
    private PropertySetNumber scoreSetter;
    private PropertyGetInteger scoreGetter;

    public ScoreController()
    {
        this.scoreSetter = new PropertySetNumber();
        this.scoreGetter = new PropertyGetInteger();
    }

    public void AddPoints(double points)
    {
        double currentScore = this.scoreGetter.Get(new Args());
        this.scoreSetter.SetValue(currentScore + points);
    }

    public double GetScore()
    {
        return this.scoreGetter.Get(new Args());
    }
}
```
