using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollect : MonoBehaviour
{

    private PlayerControl playerControl;
   // public Sprite spBullet;
    //private SpriteRenderer srBullet;
    // Start is called before the first frame update
    void Start()
    {
        playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
      //  srBullet = this.gameObject.GetComponent<SpriteRenderer>();
       // srBullet.sprite = srBullet.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerControl.iAmmo++;
            Destroy(this.gameObject);
        }
    }
}
