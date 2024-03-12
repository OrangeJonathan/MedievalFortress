using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    void Start() 
    {
        target = LevelManager.path[0];
    }

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(speed * Time.deltaTime * direction.normalized, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= LevelManager.path.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target = LevelManager.path[wavepointIndex];
    }

}
