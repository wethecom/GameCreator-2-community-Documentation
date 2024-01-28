using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInputCapture : MonoBehaviour
{
    private HashSet<KeyCode> currentlyPressedKeys = new HashSet<KeyCode>();
    public string KeyState;
    public string CurrentCombo;
    void Update()
    {
        // Check each key in the KeyCode enumeration
        foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(key))
            {
                currentlyPressedKeys.Add(key);
                LogKeyState(key, "Pressed");
                LogCurrentCombination();
            }
            else if (Input.GetKeyUp(key))
            {
                currentlyPressedKeys.Remove(key);
                LogKeyState(key, "Released");
            }
        }
    }

    void LogKeyState(KeyCode key, string state)
    {
        KeyState = "Key " + key + " " + state;
        Debug.Log("Key " + key + " " + state);
    }

    void LogCurrentCombination()
    {
        if (currentlyPressedKeys.Count > 0) // Check if any key is pressed
        {
            CurrentCombo = "Current combination: " + string.Join(" + ", currentlyPressedKeys);

            Debug.Log("Current combination: " + string.Join(" + ", currentlyPressedKeys));
        }
    }
}
