using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroButtons : MonoBehaviour
{
    public Button btnPlay, btnHome;
    // Start is called before the first frame update
    void Start()
    {
        btnHome.onClick.AddListener(BackToHome);
        btnPlay.onClick.AddListener(PlayGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene 1");
        Debug.Log("Play tutorial");
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("Main Menu");
        Debug.Log("Home");
    }
}
