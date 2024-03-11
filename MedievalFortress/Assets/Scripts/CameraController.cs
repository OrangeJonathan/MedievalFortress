using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            CameraOne();
        }
        if (Input.GetKeyDown("2"))
        {
            CameraTwo();
        }
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
