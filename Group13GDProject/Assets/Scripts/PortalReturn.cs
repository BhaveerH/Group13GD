using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalReturn : MonoBehaviour
{
    public int iCount = 0;
    public CameraControl cc;
    public GameObject PrevPortal;
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
            collision.transform.position = new Vector2(PrevPortal.transform.position.x, PrevPortal.transform.position.y + 2);
            cc.PlayerXPos = 0;
            Rigidbody2D rbPlayer = collision.gameObject.GetComponent<Rigidbody2D>();
            rbPlayer.velocity = Vector2.up * 8;
           
        }
        
        
    }
}
