using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformExplode : MonoBehaviour
{
    public int isCollect = 0;
    [SerializeField] public AudioSource platformSFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCollect == 1)
        {
            StartCoroutine(TimeDelay());

        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            platformSFX.Play();
            Rigidbody2D rbPlayer = collision.gameObject.GetComponent<Rigidbody2D>();
            rbPlayer.velocity = Vector2.up * 6;
            // Destroy(this.gameObject);
            isCollect = 1;
            
        }
    }

    IEnumerator TimeDelay()
    {

        yield return new WaitForSeconds(0.7f);
        Destroy(this.gameObject);

    }
}
