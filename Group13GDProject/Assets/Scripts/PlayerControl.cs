using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rbPlayer;
    public float velocityX, velocityY, speed = 5f, fbSpeed = 1000f, fbLength = 3f, bulletDelay = 0.2f;
    public GameObject pbBullet;
    public bool canShoot = true;
    public int iCoinKeep;
    public Text tCoins;
    // Start is called before the first frame update
    void Start()
    {
        velocityY = -10f;
    }

    // Update is called once per frame
    void Update()
    {
        iCoinKeep = CoinsTotal.coinTotal;
        tCoins.text = iCoinKeep.ToString();
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

        if (Input.GetMouseButtonDown(0) && canShoot == true)
        {
            Shooting();
        }
    }

    void Shooting()
    {
        Instantiate(pbBullet, new Vector2(transform.position.x, transform.position.y - 1), transform.rotation);
        StartCoroutine(BulletDelay());
    }

    IEnumerator BulletDelay()
    {
        canShoot = false;
        yield return new WaitForSeconds(bulletDelay);
        canShoot = true;
    }
}
