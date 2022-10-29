using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikePressure : MonoBehaviour
{
    public float timerCountUp, timerCountDown = 5, randomX;
    public bool isZero = false;
    public GameObject gCam, pbSpike;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timerCountUp += Time.deltaTime;

        timerCountDown -= Time.deltaTime;

        if (timerCountDown <= 0)
        {
            timerCountDown = 0;
            randomX = Random.Range(-8f, 8f);
            Instantiate(pbSpike, new Vector2(randomX, gCam.transform.position.y + 5), transform.rotation);
            isZero = true;
        }


        if ((timerCountUp > 0)  && (timerCountUp <= 15) && (isZero == true))
        {
            timerCountDown = 5;
            isZero = false;
        }
        else if ((timerCountUp > 15) && (timerCountUp <= 30) && (isZero == true))
        {
            timerCountDown = 3f;
            isZero = false;
        }
        else if ((timerCountUp > 30) && (timerCountUp <= 50) && (isZero == true))
        {
            timerCountDown = 1.5f;
            isZero = false;
        }
        else if ((timerCountUp > 50) && (isZero == true))
        {
            timerCountDown = 0.75f;
            isZero = false;
        }

        
    }
}
