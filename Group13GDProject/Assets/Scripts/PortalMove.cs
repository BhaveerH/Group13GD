using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMove : MonoBehaviour
{
    public CameraControl cc;
    public float CCnewXpos;
    public int iCount = 0;
    public GameObject NextPortal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           // iCount += 1;

           // if (iCount == 1)
           // {
            collision.transform.position = new Vector2(NextPortal.transform.position.x, NextPortal.transform.position.y + 2);
            Rigidbody2D rbPlayer = collision.gameObject.GetComponent<Rigidbody2D>();
            cc.PlayerXPos = CCnewXpos;
            rbPlayer.velocity = Vector2.up * 8;
            // }

            //cc.PlayerXPos = -20.8f;

        }
    }
}
