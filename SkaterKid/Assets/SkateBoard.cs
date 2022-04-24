using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkateBoard : MonoBehaviour
{

    public Rigidbody2D rb;
    public float velocity = 1;
    public SkateboardCollision skateCollider;
    public Animator skateboard;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {

            if (skateCollider.IsOnGround)
            {
                rb.velocity = Vector2.up * velocity;
                skateboard.SetBool("IsOllie", true);
            }
        }
    }
}