using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;
    private GameObject tower;
    private Renderer rend;

    void Start ()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown() 
    {
        if (CameraController.instance.GetCamera2().activeSelf) return;
        if (tower != null)
        {
            Debug.Log("Can't build there!");
            return;
        }

        GameObject towerToBuild = BuildManager.instance.GetTowerToBuild();
        tower = Instantiate(towerToBuild, transform.position, Quaternion.identity);
    }

    void OnMouseEnter()
    {
        if (CameraController.instance.GetCamera2().activeSelf) return;
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        if (CameraController.instance.GetCamera2().activeSelf) return;
        rend.material.color = startColor;
    }
}
