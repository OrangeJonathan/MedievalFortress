using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform playerBody;
    private float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActiveAndEnabled)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }

        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * GetMouseSensitivity();
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * GetMouseSensitivity();

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private float GetMouseSensitivity()
    {
        return SettingsMenu._sensitivity;
    }
}
