using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFire : MonoBehaviour
{

    float fbLength;
    GameObject player;
    PlayerControl playerController;
    Rigidbody rb;
    public Vector2 newForce = new Vector2(0f, 10000f);
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<PlayerControl>();
        fbLength = playerController.fbLength;

        Destroy(gameObject, fbLength);
    }

    void FixedUpdate()
    {

        rb.AddForce(newForce, (ForceMode)ForceMode2D.Impulse);
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
 
    }
}
