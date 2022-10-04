using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rbPlayer;
    public float velocityX, velocityY, speed = 5f, fbSpeed = 1000f, fbLength = 3f, bulletDelay = 1f, EnemyTouchDelay = 3f, currentTime = 0f;
    public GameObject pbBullet, Heart, Heart1, Heart2;
    public bool canShoot = true, canTouch = true, isDead = false, gotKey = false, isTimer = false;
    public int iCoinKeep, iLives = 3, iAmmo = 6;
    public Text tCoins, tAmmo;
    private float startTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        velocityY = -7f;
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

        if ((Input.GetKey(KeyCode.Space)) && (rbPlayer.velocity.y >= -2.5f) && (rbPlayer.velocity.y <= 2.5f))        //perfroms the jump when the spacebar is pressed
        {
            rbPlayer.velocity = Vector2.up * 8;
        }

         if (rbPlayer.velocity.y <= -7f)                                       //makes sure the y velocity does not exceed -10
         {
             rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, velocityY);
         }

        if (Input.GetMouseButtonDown(0) && canShoot == true && iAmmo >= 1)
        {
            Shooting();
            iAmmo = iAmmo - 1;
        }

        if ((iAmmo < 6) && (isTimer == false))
        {
            currentTime = startTime;
            isTimer = true;
        }

        if (isTimer == true)        //this timer puts the object back to original state
        {
            currentTime -= 1 * Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
            }

            if (currentTime == 0)
            {
                iAmmo = iAmmo + 1;
                isTimer = false;
            }
        }

        tAmmo.text = iAmmo.ToString();

        if (iAmmo <= 0)
        {
            tAmmo.text = 0.ToString();
        }

        if (isDead == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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

        if (collision.gameObject.tag == "EndOfLevel")
        {
            if (gotKey == false)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else if (gotKey == true)
            {
                if (SceneManager.GetActiveScene().name == "SampleScene 1")
                {
                    SceneManager.LoadScene("Level_1");
                }
                else if (SceneManager.GetActiveScene().name == "Level_1")
                {
                    SceneManager.LoadScene("Level_2");
                }
            }
        }

      
    }

    IEnumerator EnemyLandDelay()
    {
        canTouch = false;
        yield return new WaitForSeconds(EnemyTouchDelay);
        canTouch = true;
    }
}
