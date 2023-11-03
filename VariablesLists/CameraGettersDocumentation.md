
# Game Creator Camera Retrieval Properties

## Overview
These classes facilitate the retrieval of camera references from global and local variables within Game Creator 2. They provide targeted access to camera properties, enabling dynamic camera control throughout your game.

## Class Summaries

### GetCameraGlobalList
Obtains the camera value from a specified index of a Global List Variable. It can be used to switch between different cameras available game-wide.

### GetCameraGlobalName
Fetches the camera value of a Global Variable identified by a unique name. Useful for referencing cameras that are consistent throughout the game.

### GetCameraLocalList
Obtains the camera value from a specified index of a Local List Variable. Ideal for scene-specific cameras that change depending on the local context.

### GetCameraLocalName
Fetches the camera value of a Local Variable identified by a unique name. Used for referencing cameras within a local scope, such as within a single scene or object.

## Usage Example
Here's a conceptual example of how to switch cameras based on various conditions using these classes:

```csharp
using GameCreator.Runtime.Cameras;
using GameCreator.Runtime.Variables;

public class CameraSwitcher
{
    // Assume these variables are initialized and set up elsewhere in the game code
    private GetCameraGlobalList getGlobalListCamera;
    private GetCameraGlobalName getGlobalNameCamera;
    private GetCameraLocalList getLocalListCamera;
    private GetCameraLocalName getLocalNameCamera;

    public void SwitchToGlobalListCamera(int index)
    {
        CameraController camera = getGlobalListCamera.Get(index);
        if (camera != null) camera.Use();
    }

    public void SwitchToGlobalNameCamera(string name)
    {
        CameraController camera = getGlobalNameCamera.Get(name);
        if (camera != null) camera.Use();
    }

    // Similar methods would be implemented for local list and name cameras
}
```

## Note
The `Get()` method and `CameraController.Use()` in the example are hypothetical and illustrate how you might retrieve and use camera references in practice. The actual implementation may differ based on your game's specific requirements and the Game Creator 2 API.
