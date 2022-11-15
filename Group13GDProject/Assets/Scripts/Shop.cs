using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    public Button btnLevel2, btnLevel3, btnLevel4, btnLevel5, btnOkay;
    public int l4Cost, l5Cost, lNum;
    public float fTimeDelay = 0.5f;
    public Text tCoinsTotal;
    public GameObject g4Coin, g4Text, g5Coin, g5Text, gPanel;
    // Start is called before the first frame update
    void Start()
    {
        btnLevel2.onClick.AddListener(level2);
        btnLevel3.onClick.AddListener(level3);
        btnLevel4.onClick.AddListener(level4);
        btnLevel5.onClick.AddListener(level5);
        btnOkay.onClick.AddListener(bOkay);
    }

    // Update is called once per frame
    void Update()
    {
        tCoinsTotal.text = CoinsTotal.coinTotal.ToString();
    }

    public void level2()
    {
        lNum = 2;
        StartCoroutine(TimeDelay());
    }

    public void level3()
    {
        lNum = 3;
        StartCoroutine(TimeDelay());
    }

    public void level4()
    {
        if ((ShopVarHolder.bLevel4 == true) && (CoinsTotal.coinTotal - l4Cost >= 0))
        {
            lNum = 4;
            g4Coin.SetActive(false);
            g4Text.SetActive(false);
            CoinsTotal.coinTotal -= l4Cost;
            StartCoroutine(TimeDelay());
        }
        else
        {
            gPanel.SetActive(true);
        }
    }

    public void level5()
    {
        if ((ShopVarHolder.bLevel5 == true) && (CoinsTotal.coinTotal - l5Cost >= 0))
        {
            lNum = 5;
            g5Coin.SetActive(false);
            g5Text.SetActive(false);
            CoinsTotal.coinTotal -= l5Cost;
            StartCoroutine(TimeDelay());
        }
        else
        {
            gPanel.SetActive(true);
        }
    }

    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(fTimeDelay);
        switch (lNum)
        {
            case 2: SceneManager.LoadScene("WATER LEVEL (L2) 1");
                break;
            case 3: ShopVarHolder.bLevel4 = true;
                    SceneManager.LoadScene("DESERT LEVEL (L3)");
                break;
            case 4: ShopVarHolder.bLevel5 = true;
                    SceneManager.LoadScene("ICE LEVEL (L4)");
                break;
            case 5: SceneManager.LoadScene("FIRE  LEVEL (L5)");
                break;
        }
    }


    public void bOkay()
    {
        gPanel.SetActive(false);
    }

}
