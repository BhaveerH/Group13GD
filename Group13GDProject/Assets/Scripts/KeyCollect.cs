using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    public PlayerControl PlayerController;
    public GameObject CanvasKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
               PlayerController.gotKey = true;
               CanvasKey.SetActive(true);
               Destroy(this.gameObject);
            
        }
    }
}
