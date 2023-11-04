
# Game Creator Shot Retrieval Properties

## Overview
This section documents classes that are responsible for retrieving Camera Shot values from various variables in Game Creator 2. These properties enable the manipulation of camera shots dynamically, which is a powerful tool for cinematic and gameplay elements.

## Class Summaries

### Shot Retrieval Classes
- `GetShotGlobalList`: Retrieves a Camera Shot from a Global List Variable by index.
- `GetShotGlobalName`: Obtains a Camera Shot from a Global Name Variable.
- `GetShotLocalList`: Fetches a Camera Shot from a Local List Variable by index.
- `GetShotLocalName`: Retrieves a Camera Shot from a Local Name Variable.

## Usage Example
The following is a hypothetical example showcasing how to use these classes:

```csharp
using GameCreator.Runtime.Cameras;
using GameCreator.Runtime.Variables;
using UnityEngine;

public class CameraShotManager
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetShotGlobalList globalListShotGetter;
    private GetShotGlobalName globalNameShotGetter;
    // Other getters for local list and name would be defined similarly

    public Shot GetGlobalListShot(int index)
    {
        // Retrieves Camera Shot from the specified index in the global list
        return globalListShotGetter.Get(index);
    }

    public Shot GetGlobalNameShot(string name)
    {
        // Retrieves Camera Shot from a global name variable
        return globalNameShotGetter.Get(name);
    }

    // Additional methods for local list and name shot retrievals would follow a similar pattern
}
```

## Note
The `Get()` method shown in the examples is representative. Actual implementation details might differ, and these examples should be adapted according to the specific API of Game Creator 2 and your game's requirements.
