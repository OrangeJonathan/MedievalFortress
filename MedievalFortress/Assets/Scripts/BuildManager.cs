using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }
        instance = this;
    }

    // public GameObject[] towerPrefabs;
    public GameObject towerPrefab;
    public float towerIndex;

    void Start()
    {
    //    towerToBuild = towerPrefabs[0];
        towerToBuild = towerPrefab;
    }

    private GameObject towerToBuild;

    public GameObject GetTowerToBuild()
    {
        return towerToBuild;
    }
}
