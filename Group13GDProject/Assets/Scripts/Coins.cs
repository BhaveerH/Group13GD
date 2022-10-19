using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int iCollect = 10;
    //public bool iEnter = false;
    // Start is called before the first frame update

    [SerializeField] public AudioSource coinCollectSFX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            coinCollectSFX.Play();
            CoinsTotal.coinTotal += iCollect;
            Destroy(this.gameObject);
           
            
        }
    }
}
