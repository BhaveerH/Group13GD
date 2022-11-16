using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlButton : MonoBehaviour
{
    public Button btnPlayLevel, btnExit;
    // Start is called before the first frame update
    void Start()
    {
        btnPlayLevel.onClick.AddListener(Level1Play);
        btnExit.onClick.AddListener(BackToHome);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level1Play()
    {
        SceneManager.LoadScene("JUNGLE LEVEL (L1)");
    }

    public void BackToHome()
    {
        //SceneManager.LoadScene("Main Menu");
        // creditPanel.SetActive(false);
        SceneManager.LoadScene("Main Menu");
        Debug.Log("Home");
    }
}
