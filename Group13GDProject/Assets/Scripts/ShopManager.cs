using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    //Tutorial https://www.youtube.com/watch?v=Oie-G5xuQNA&t=475s
    //this shop works with the logic that the bullets are limited every level.

    public int[,] shopItems = new int[7, 7];

    // Start is called before the first frame update
    void Start()
    {
        //Bullet ID

        //Basic
        shopItems[1, 1] = 1;
        //Water
        shopItems[1, 2] = 2;
        //Desert
        shopItems[1, 3] = 3;
        //Lava
        shopItems[1, 4] = 4;
        //Ice
        shopItems[1, 5] = 5;
        //Bonus level potentially
        shopItems[1, 6] = 6;

        //Price of item

        //One coin because these have no real effects yet
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 10;
        shopItems[2, 3] = 10;
        //Bullets with effects (fire and ice)
        shopItems[2, 4] = 20;
        shopItems[2, 5] = 20;
        //Bonus level
        shopItems[2, 6] = 10000;
    }

    /*
    pubic void Buy()
    {
    GameObject ButtonRef = GameObject.FindGameObjectWithTag("event").GetComponent<Event>
    }
    
    */
    
}
