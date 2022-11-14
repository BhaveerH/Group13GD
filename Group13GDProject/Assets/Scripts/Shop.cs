using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    public Button btnLevel1, btnLevel2, btnLevel3, btnLevel4, btnLevel5;
    public int l1Cost, l2Cost, l3Cost, l4Cost, l5Cost;
    // Start is called before the first frame update
    void Start()
    {
        btnLevel1.onClick.AddListener(level1);
        btnLevel2.onClick.AddListener(level2);
        btnLevel3.onClick.AddListener(level3);
        btnLevel4.onClick.AddListener(level4);
        btnLevel5.onClick.AddListener(level5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void level1()
    {
        CoinsTotal.coinTotal = CoinsTotal.coinTotal - l1Cost;

        ShopVarHolder.bLevel2 = true;

        // put next scene
    }

    public void level2()
    {
        if ((ShopVarHolder.bLevel2 == true) && (CoinsTotal.coinTotal - l2Cost >= 0))
        {
            ShopVarHolder.bLevel3 = true;

            // put next scene
        }
    }

    public void level3()
    {
        if ((ShopVarHolder.bLevel3 == true) && (CoinsTotal.coinTotal - l3Cost>= 0))
        {
            ShopVarHolder.bLevel4 = true;

            // put next scene
        }
    }

    public void level4()
    {
        if ((ShopVarHolder.bLevel4 == true) && (CoinsTotal.coinTotal - l4Cost >= 0))
        {
            ShopVarHolder.bLevel5 = true;

            // put next scene
        }
    }

    public void level5()
    {
        if ((ShopVarHolder.bLevel5 == true) && (CoinsTotal.coinTotal - l5Cost >= 0))
        {
            

            // put next scene
        }
    }

}
