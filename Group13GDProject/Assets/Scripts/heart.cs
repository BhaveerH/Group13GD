using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerControl PlayerControl;
    public GameObject goHeartCanvas;
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
            PlayerControl.iLives = PlayerControl.iLives + 1;
            goHeartCanvas.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
