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
        MoveEnemyToNextWayPoint();

        //Enemy reached target
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

    }

    void MoveEnemyToNextWayPoint()  
    {
        //Move enemy towards target
        Vector3 direction = target.position - transform.position;

        transform.Translate(speed * Time.deltaTime * direction.normalized, Space.World);

        // Calculate the direction for rotation
        Vector3 flatDirection = new Vector3(target.position.x - transform.position.x, target.position.y - transform.position.y, target.position.z - transform.position.z);
        Quaternion flatRotation = Quaternion.LookRotation(flatDirection);

        // Convert to euler angles, and only change the Y rotation
        Vector3 targetEulerAngles = flatRotation.eulerAngles;
        float initialXRotation = transform.rotation.eulerAngles.x;
        float initialZRotation = transform.rotation.eulerAngles.z;
        targetEulerAngles.x = initialXRotation; 
        targetEulerAngles.z = initialZRotation; 

        // Convert back to quaternion rotation
        Quaternion targetRotation = Quaternion.Euler(targetEulerAngles);

        // Rotate towards the target rotation
        float rotationSpeed = 5f;
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
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
