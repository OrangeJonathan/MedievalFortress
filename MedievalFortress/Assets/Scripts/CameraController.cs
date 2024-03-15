using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public static CameraController instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one CameraController in scene!");
            return;
        }
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            CameraOne();
            Cursor.lockState = CursorLockMode.None;
        }
        if (Input.GetKeyDown("2"))
        {
            CameraTwo();
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public GameObject GetCamera1()
    {
        return camera1;
    }
    
    public GameObject GetCamera2()
    {
        return camera2;
    }

    void CameraOne()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
    }

    void CameraTwo()
    {
        camera1.SetActive(false);
        camera2.SetActive(true);
    }
}
