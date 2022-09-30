using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementRight : MonoBehaviour
{
    public float speed = 2f;
    public Vector2 StartPos;
    public Vector2 EndPos;
    public float HoverDistance;
    public bool moveUp;
    public int iBulletHit = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
        // EndPos = StartPos - new Vector2(HoverDistance, 0);
        EndPos = new Vector2(EndPos.x, StartPos.y);
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
    }



    void Walk()     //this function when called, makes this object 'walk' back and forth 
    {

        if (transform.position.x == StartPos.x)
        {
            moveUp = true;
        }
        else if (transform.position.x == EndPos.x)
        {
            moveUp = false;
        }

        if (moveUp == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, EndPos, 1 * speed * Time.deltaTime);
            transform.localScale = new Vector3(-3, transform.localScale.y, transform.localScale.z);     //changes the direction object is facing
        }

        if (moveUp == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, StartPos, 1 * speed * Time.deltaTime);
            transform.localScale = new Vector3(3, transform.localScale.y, transform.localScale.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            iBulletHit = iBulletHit + 1;
        }

        if (iBulletHit >= 1)
        {
            Destroy(this.gameObject);
        }
    }
}
