using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public static float _sensitivity = 150f;
    public void SetSensitivity (float sensitivity)
    {
        _sensitivity = sensitivity;
    }
}
