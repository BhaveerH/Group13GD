using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureCollide : MonoBehaviour
{
    private Rigidbody2D rbSpike;
    public float timerCountDown;
    public bool isTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        rbSpike = this.gameObject.GetComponent<Rigidbody2D>();
        timerCountDown = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        if (rbSpike.velocity.y <= -2.5f)
        {
            rbSpike.velocity = new Vector2(rbSpike.velocity.x, -2.5f);
        }

        
            timerCountDown -= Time.deltaTime;

            if (timerCountDown <= 0)
            {
                timerCountDown = 0;
                Destroy(this.gameObject);

            }
     
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

    }
}
