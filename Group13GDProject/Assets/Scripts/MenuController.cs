using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene 1");
        Debug.Log("Play tutorial");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("MainMenu");
    }

    /*public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }*/
}
