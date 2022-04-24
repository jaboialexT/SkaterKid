using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkateboardCollision : MonoBehaviour
{
    public Animator skateboard;
    public bool isGrounded = true;

    public bool IsOnGround
    {
        get
        {
            if (isGrounded)
            {
                isGrounded = false;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        skateboard.SetBool("IsOllie", false);
    }
}
