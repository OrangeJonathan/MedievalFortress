using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave 
{
    public int waveNumber;
    public int enemyCount;
    public Enemy[] enemyTypes;
    public float timeBetweenSpawns;

    public Wave(int waveNumber, int enemyCount, Enemy[] enemyTypes, float timeBetweenSpawns)
    {
        this.waveNumber = waveNumber;
        this.enemyCount = enemyCount;
        this.enemyTypes = enemyTypes;
        this.timeBetweenSpawns = timeBetweenSpawns;
    }
    public void SpawnWave()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            new WaitForSeconds(timeBetweenSpawns);
            for (int j = 0; j < enemyTypes.Length; j++) 
            {
                enemyTypes[j].SpawnEnemy();
            }
        }
    }

}
