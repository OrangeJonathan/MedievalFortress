using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType 
{
    BaseEnemy,
}
public class Enemy : MonoBehaviour
{
    public EnemyType enemyType;
    public float enemySpeed;
    public int enemyHealth;

    public Enemy(EnemyType enemyType, float enemySpeed, int enemyHealth)
    {
        this.enemyType = enemyType;
        this.enemySpeed = enemySpeed;
        this.enemyHealth = enemyHealth;
    }
    public void SpawnEnemy()
    {
        //SpawnThisEnemy(EnemyIndex);
    }
}
