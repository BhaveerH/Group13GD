using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerControl PlayerControl;
    public GameObject goHeartCanvas;
    public float speed = 2f;
    Vector2 StartPos;
    Vector2 EndPos;
    public float HoverDistance;

    private float startPosx;
    private bool moveUp;
    private bool isStartTrue = false;



    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
        EndPos = StartPos + new Vector2(0, HoverDistance);

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
            PlayerControl.iLives = PlayerControl.iLives + 1;
            goHeartCanvas.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
