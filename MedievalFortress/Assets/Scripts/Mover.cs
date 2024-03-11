using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xMove = -Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zMove = -Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        rigidbody.velocity = new Vector3(xMove, rigidbody.velocity.y, zMove) * moveSpeed;
    }
}
