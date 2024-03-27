using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner instance;
    public Transform[] allEnemyPrefabs;
    public Transform spawnPoint;
    public Text waveTimer;
    public Enemy[] allEnemies;

    void Start()
    {
        instance = this;
    }
    void Update()
    {
        //waveCountDownText.text = Mathf.Round(countdown).ToString();
    }
    public void SpawnThisEnemy(int enemyIndex)
    {
        //Enemy index invalid

        Transform enemyPrefab = allEnemyPrefabs[enemyIndex];
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        //Instantiate(enemyPrefab, spawnPoint.position, enemyPrefab.rotation);
    }

    void SpawnDefaultEnemy()
    {
        //Instantiate(enemyPrefab, spawnPoint.position, enemyPrefab.rotation);
    }
}


