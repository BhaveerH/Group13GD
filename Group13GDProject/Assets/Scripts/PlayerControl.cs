using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rbPlayer;
    public float velocityX, velocityY, speed = 5f, fbSpeed = 1000f, fbLength = 3f, bulletDelay = 0.4f, EnemyTouchDelay = 3f;
    public GameObject pbBullet, Heart, Heart1, Heart2;
    public bool canShoot = true, canTouch = true, isDead = false;
    public int iCoinKeep, iLives = 3;
    public Text tCoins;
    // Start is called before the first frame update
    void Start()
    {
        velocityY = -10f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 eulerRotation = transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 0);
        iCoinKeep = CoinsTotal.coinTotal;
        tCoins.text = iCoinKeep.ToString();
        velocityX = Input.GetAxis("Horizontal") * speed;        //gets the horizontal axis, the keys that need to pressed to move are pre assigned 
        rbPlayer.velocity = new Vector2(velocityX, rbPlayer.velocity.y);        //updates the movement

        if ((Input.GetKey(KeyCode.Space)) && (rbPlayer.velocity.y >= 0))        //perfroms the jump when the spacebar is pressed
        {
            rbPlayer.velocity = Vector2.up * 8;
        }

         if (rbPlayer.velocity.y <= -10f)                                       //makes sure the y velocity does not exceed -10
         {
             rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, velocityY);
         }
        Debug.Log(rbPlayer.velocity.y);

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Enemy") && (canTouch == true))
        {
            iLives = iLives - 1;

            switch (iLives)
            {
                case 2: Destroy(Heart);
                    break;
                case 1: Destroy(Heart1);
                    break;
                case 0: Destroy(Heart2);
                    isDead = true;
                    break;              
            }
            StartCoroutine(EnemyLandDelay());
        }
    }

    IEnumerator EnemyLandDelay()
    {
        canTouch = false;
        yield return new WaitForSeconds(EnemyTouchDelay);
        canTouch = true;
    }
}
