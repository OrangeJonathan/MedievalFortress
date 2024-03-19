using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float HitPoints = 200f;
    public float goldReward = 10f;
    
    public void TakeDamage(float amount)
    {
        HitPoints -= amount;
        if (HitPoints <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        CoinCounter.instance.IncreaseCoins((int)goldReward);
    }
}
