using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkaterGuy : MonoBehaviour
{
    // Update is called once per frame
    public Rigidbody2D rb;
    public float velocity = 1;
    public PlayerCollider playerCollider;
    public Animator player;
    string lastKey = "d";
    public float combo = 1f;
    public float score = 0f;
    public int health = 3;
   
    
    public string key
    {
        get { return lastKey; }
    }

    public void resetCombo()
    {
        health--;
        combo = 1f;
        player.SetInteger("Side",0);
        lastKey = "d";
    }
   


    void Update()
    {
        score += (int)(Time.timeSinceLevelLoad*combo);
        
        if (Input.GetButtonDown("Jump"))
        {
            
             if(playerCollider.IsOnGround)
            {
                rb.velocity = Vector2.up * velocity;
            }
            
        }
        if (!playerCollider.Grounded)
        {
            if (Input.GetKeyDown("w"))
            {
                if (lastKey == "d")
                {
                    player.SetInteger("Side", 1);
                    lastKey = "w";
                }
               
            }
            if (Input.GetKeyDown("a"))
            {
                if (lastKey == "w")
                {
                    player.SetInteger("Side", 2);
                    lastKey = "a";
                }
                
            }
            if (Input.GetKeyDown("s"))
            {
                if (lastKey == "a")
                {
                    player.SetInteger("Side", 3);
                    lastKey = "s";
                }
                
            }
            if (Input.GetKeyDown("d"))
            {
                if (lastKey == "s")
                {
                    player.SetInteger("Side", 0);
                    lastKey = "d";
                    combo ++;
                }
               
            }
        }
        
            /*switch (button){
                                case 'w':
                                    if(d is last button pressed){
                                    turn sprite back
                                    }
                                    break
                                case 'a':
                                    if(w is last button pressed){
                                    turn sprite left
                                    }
                                    break
                                case 's':
                                    if(a is last button pressed){
                                    turn sprite forward
                                    }
                                    break
                               case 'd':
                                    if(s is last button pressed){
                                    turn sprite right
                                    add 1 to combo
                                    }
                                    break
                          }
         */
    }
}
