using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    private bool m_FacingRight = true;
    float previousPositionx = 0f;
    float previousPositiony = 0f;

    void FixedUpdate()
    {
        if (Detection.detection == true)
        {
            gameObject.GetComponent<Patrol>().enabled = false;
            gameObject.GetComponent<AIDestinationSetter>().enabled = true;
        }
        if (transform.position.x - previousPositionx > 0 && !m_FacingRight)
        {
            flip();
        }
        if (transform.position.x - previousPositionx < 0 && m_FacingRight)
        {
            flip();
        }
        if ((transform.position.x - previousPositionx == 0) && (transform.position.y - previousPositiony == 0))
        {
            animator.SetBool("isIdle", true);
            animator.SetBool("isWalking", false);
        }
        else
        {
            animator.SetBool("isIdle", false);
            animator.SetBool("isWalking", true);
        }
        previousPositionx = transform.position.x;
        previousPositiony = transform.position.y;
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
