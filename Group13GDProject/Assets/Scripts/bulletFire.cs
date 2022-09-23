using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFire : MonoBehaviour
{

    float fbLength;
    GameObject player;
    PlayerControl playerController;
    Rigidbody2D rb;
    public Vector2 newForce = new Vector2(0f, 10000f);
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<PlayerControl>();
        fbLength = playerController.fbLength;

        Destroy(gameObject, fbLength);
    }

    void FixedUpdate()
    {

        // rb.AddForce(newForce, (ForceMode)ForceMode2D.Impulse);
        Vector3 eulerRotation = transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, -90);
    }

   
    private void OnCollisionEnter(Collision collision)
    {
 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
