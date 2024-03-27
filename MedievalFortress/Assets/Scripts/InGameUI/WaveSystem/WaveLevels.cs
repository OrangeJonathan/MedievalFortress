using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveLevels : MonoBehaviour
{
    public static WaveLevels instance;

    public Wave[] allWaves;
    void Start()
    {
        instance = this;
        Enemy[] AllEnemies = EnemySpawner.instance.allEnemies;
        //allWaves.Add(new Wave(1, 10, new Enemy[] { new Enemy(1, 1, 1, 1) }, 1));
    }

    void Update()
    {
        
    }
}

