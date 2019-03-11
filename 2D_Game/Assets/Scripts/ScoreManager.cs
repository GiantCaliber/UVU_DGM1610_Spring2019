using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    
    //cannot change the declaration/modify it anywhere;
    public static int score;
    
    private Text scoreText;

	// Use this for initialization
	void Start () {
        //Gets UI text component
		scoreText = GetComponent<Text>();
        
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (score < 0) { //single line does not need braces (but I have it anyways for reading intentions)
            score = 0;
        }
        scoreText.text = " " + score;
	}
    
    public static void AddPoints (int pointsToAdd) {
        print("Coin Collected");
        score += pointsToAdd;
    }
    
//    public static void Reset () {
//        score = 0;
//    }
}
