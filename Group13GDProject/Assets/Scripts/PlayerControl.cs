using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rbPlayer;
    public float velocityX, velocityY, speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        velocityY = -10f;
    }

    // Update is called once per frame
    void Update()
    {

        velocityX = Input.GetAxis("Horizontal") * speed;        //gets the horizontal axis, the keys that need to pressed to move are pre assigned 
        rbPlayer.velocity = new Vector2(velocityX, rbPlayer.velocity.y);        //updates the movement

        if ((Input.GetKey(KeyCode.Space)) && (rbPlayer.velocity.y == 0))        //perfroms the jump when the spacebar is pressed
        {
            rbPlayer.velocity = Vector2.up * 8;
        }

         if (rbPlayer.velocity.y <= -10f)                                       //makes sure the y velocity does not exceed -10
         {
             rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, velocityY);
         } 
    }
}
