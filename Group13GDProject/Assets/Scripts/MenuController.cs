using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button btnPlay, btnQuit, btnHome, btnCredits;
    public GameObject creditPanel;
    private void Start()
    {
        btnHome.onClick.AddListener(BackToHome);
        btnPlay.onClick.AddListener(PlayGame);
        btnQuit.onClick.AddListener(QuitGame);
        btnCredits.onClick.AddListener(Credits);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("INTRO SCENE");
        Debug.Log("Play tutorial");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void BackToHome()
    {
        //SceneManager.LoadScene("Main Menu");
        // creditPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Home");
    }

    public void Credits()
    {
        creditPanel.SetActive(true);
    }

    /*public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }*/
}
