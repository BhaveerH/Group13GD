using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollect : MonoBehaviour
{

    private PlayerControl playerControl;
    // public Sprite spBullet;
    //private SpriteRenderer srBullet;
    public float speed = 0.4f;
    Vector2 StartPos;
    Vector2 EndPos;
    public float HoverDistance = 0.5f;

    private float startPosx;
    private bool moveUp;
    private bool isStartTrue = false;
    // Start is called before the first frame update
    void Start()
    {
        playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
        StartPos = transform.position;
        EndPos = StartPos + new Vector2(0, HoverDistance);
        //  srBullet = this.gameObject.GetComponent<SpriteRenderer>();
        // srBullet.sprite = srBullet.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        startPosx = transform.position.x;
        if (StartPos.x == startPosx)
        {
            isStartTrue = true;
        }
        else
        {
            isStartTrue = false;
        }

        if (isStartTrue == false)
        {
            EndPos = StartPos;
            StartPos = transform.position;
            EndPos += StartPos;
        }

        if (transform.position.y == StartPos.y)
        {
            moveUp = true;
        }
        else if (transform.position.y == EndPos.y)
        {
            moveUp = false;
        }

        if (moveUp == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, EndPos, 1 * speed * Time.deltaTime);
        }

        if (moveUp == false)
        {

            transform.position = Vector2.MoveTowards(transform.position, StartPos, 1 * speed * Time.deltaTime);

        }
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
