using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://answers.unity.com/questions/667641/how-do-i-move-my-2d-object-using-arrow-keys-also-h.html

public class Player_Movement : MonoBehaviour
{
    float defaultSpeed = 1.5f;
    float runSpeed = 4;
    [SerializeField]
    float speed = 1.5f;
    Vector3 moveVector;
    void FixedUpdate()
    {
        transform.position += moveVector * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = runSpeed;
        }
        else
        {
            speed = defaultSpeed;
        }

    }
    void Update()
    {
        moveVector = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed;
    }
}
