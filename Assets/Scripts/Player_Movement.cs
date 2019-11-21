using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://answers.unity.com/questions/667641/how-do-i-move-my-2d-object-using-arrow-keys-also-h.html

public class Player_Movement : MonoBehaviour
{
<<<<<<< HEAD
    float defaultSpeed = 2.5f;
    float runSpeed = 4.5f;
    [SerializeField]
    float speed = 1.5f;
=======
    float defaultSpeed = 3f;
    float runSpeed = 9f;
    float speed = 0f;
>>>>>>> c7dfaae69ccb52d8b296abbf392f8d889aa589f5
    Vector3 moveVector;
    public Animator animator;
    private bool m_FacingRight = true;

    void FixedUpdate()
    {
        transform.position += moveVector * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = runSpeed;
            animator.SetBool("isRunning", true);
            animator.SetBool("isWalking", false);

        }
        else
        {
            speed = defaultSpeed;
            animator.SetBool("isWalking", true);
            animator.SetBool("isRunning", false);
        }
        if (Mathf.Abs(Input.GetAxis("Horizontal")) <= 0.1)
        {
            animator.SetBool("isIdle", true);
            animator.SetBool("isWalking", false);
            animator.SetBool("isRunning", false);
        }
        else
        {
            animator.SetBool("isIdle", false);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) 
        {
            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);
        }

        


    }
    void Update()
    {
        moveVector = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed;

        if (Input.GetAxis("Horizontal") > 0.1 && !m_FacingRight)
        {
            flip();
        }
        if (Input.GetAxis("Horizontal") < 0.1 && m_FacingRight)
        {
            flip();
        }
        
    }

    private void flip()
    {
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        
    }
}
