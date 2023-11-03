
# Game Creator Instantiate Properties

## Overview
The `PropertyGetInstantiate` class is part of Game Creator's common runtime library and extends the `PropertyGetGameObject` class to provide instantiation of GameObjects with optional pooling and duration features.

## Usage
The class allows for the instantiation of GameObjects, with optional object pooling to improve performance and an optional duration after which the instantiated GameObject is automatically destroyed.

### Initialization
```csharp
PropertyGetInstantiate getInstantiate = new PropertyGetInstantiate();
```

### Properties
- `usePooling`: Whether to use object pooling (default is `false`).
- `size`: The pool size if pooling is used (default is `5`).
- `hasDuration`: Whether the instantiated object has a duration (default is `false`).
- `duration`: The duration in seconds before the instantiated object is destroyed (default is `10f`).

### Instantiating a GameObject
Assuming a method `Instantiate(GameObject prefab, Vector3 position, Quaternion rotation)` exists within the class.
```csharp
GameObject prefab; // Assume this is already initialized
Vector3 position = new Vector3(0, 0, 0);
Quaternion rotation = Quaternion.identity;

// Instantiate a GameObject at the specified position with the specified rotation
GameObject instance = getInstantiate.Instantiate(prefab, position, rotation);
```

## Example
Here is an example of how to instantiate an enemy GameObject with a lifespan of 30 seconds.

```csharp
using GameCreator.Runtime.Common;
using UnityEngine;

public class EnemySpawner
{
    private PropertyGetInstantiate instantiateEnemy;

    public EnemySpawner()
    {
        this.instantiateEnemy = new PropertyGetInstantiate
        {
            usePooling = true,
            size = 10,
            hasDuration = true,
            duration = 30f
        };
    }

    public void SpawnEnemy(GameObject enemyPrefab, Vector3 spawnPosition)
    {
        Quaternion spawnRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
        this.instantiateEnemy.Instantiate(enemyPrefab, spawnPosition, spawnRotation);
    }
}
```
