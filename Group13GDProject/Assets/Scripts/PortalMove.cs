using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMove : MonoBehaviour
{
    public CameraControl cc;
    public float newXpos, newYPos;
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
            collision.transform.position = new Vector2(newXpos, newYPos);
            cc.PlayerXPos = -20.8f;
        }
    }
}
