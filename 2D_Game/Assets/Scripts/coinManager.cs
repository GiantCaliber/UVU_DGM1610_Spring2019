using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinManager : MonoBehaviour {

    //cannot change the declaration/modify it anywhere;
    public static int coinCount;

    private Text coinText;

    // Use this for initialization
    void Start()
    {
        //Gets UI text component
        coinText = GetComponent<Text>();

        coinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (coinCount < 0)
        { //single line does not need braces (but I have it anyways for reading intentions)
            coinCount = 0;
        }
        coinText.text = " " + coinCount;
    }

    public static void AddCoins()
    {
        coinCount++;
    }
}
