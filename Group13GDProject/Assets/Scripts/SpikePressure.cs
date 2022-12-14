using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikePressure : MonoBehaviour
{
    public float timerCountUp, timerCountDown = 5;
    public bool isZero = false;
    public GameObject gCam, pbSpike;
    public int randomX;
    
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
            randomX = Random.Range(1, 3);

            if (randomX == 1)
            {
                Instantiate(pbSpike, new Vector2(-2.9f, gCam.transform.position.y + 5), transform.rotation);
            }
            else
            {
                Instantiate(pbSpike, new Vector2(3.17f, gCam.transform.position.y + 5), transform.rotation);
            }
            
            isZero = true;
        }


        if ((timerCountUp > 0)  && (timerCountUp <= 20) && (isZero == true))
        {
            timerCountDown = 5;
            isZero = false;
        }
        else if ((timerCountUp > 20) && (isZero == true))
        {
            timerCountDown = 3.5f;
            isZero = false;
        }
      /*  else if ((timerCountUp > 40) && (timerCountUp <= 60) && (isZero == true))
        {
            timerCountDown = 2.5f;
            isZero = false;
        }
        else if ((timerCountUp > 60) && (isZero == true))
        {
            timerCountDown = 1.5f;
            isZero = false;
        } */

        
    }
}
