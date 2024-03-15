using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacer : MonoBehaviour
{
    public GameObject popUpBox;
    public GameObject[] towerPrefabs;

    void OnMouseDown()
    {
        Instantiate(towerPrefabs[0], transform.position, Quaternion.identity);
    }
}
