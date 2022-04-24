using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public SkaterGuy skater;
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

    public bool Grounded
    {
        get
        {
            if (isGrounded)
            {
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
        if (skater.key != "d")
        {
            skater.resetCombo();
        }
        isGrounded = true;
    }
}
