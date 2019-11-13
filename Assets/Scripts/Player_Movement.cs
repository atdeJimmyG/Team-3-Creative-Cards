using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://answers.unity.com/questions/667641/how-do-i-move-my-2d-object-using-arrow-keys-also-h.html

public class Player_Movement : MonoBehaviour
{
    public float speed = 1.5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += Vector3.left * (4 * speed) * Time.deltaTime;
            }
            else
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += Vector3.right * (4 * speed) * Time.deltaTime;
            }
            else
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += Vector3.up * (4 * speed) * Time.deltaTime;
            }
            else
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += Vector3.down * (4 * speed) * Time.deltaTime;
            }
            else
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
            }
        }
    }
}
