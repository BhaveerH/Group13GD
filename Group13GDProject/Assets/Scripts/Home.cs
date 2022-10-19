using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Home : MonoBehaviour
{
    public Button btnHome;
    // Start is called before the first frame update
    void Start()
    {
        btnHome.onClick.AddListener(BackToHome);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("Main Menu");
        Debug.Log("Home");
    }
}
