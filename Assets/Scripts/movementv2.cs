using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementv2 : MonoBehaviour
{
    public Rigidbody2D rb;
    

    Vector2 movement;

    public float moveSpeed = 5f;

    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}
