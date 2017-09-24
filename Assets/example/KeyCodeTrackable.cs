using StateTracker;
using System;
using UnityEngine;

public class KeyCodeTrackable : TrackableBehaviour<KeyCode>
{
    private KeyCode _lastKey;

    public override KeyCode CurrentState
    {
        get
        {
            return _lastKey;
        }
    }

    void Update()
    {
        foreach (KeyCode key in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(key))
            {
                _lastKey = key;
            }
        }
    }
}
