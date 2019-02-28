using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_Statements : MonoBehaviour {
    
    public string stopLight;
    public bool badDriver = true;
    
    private int frameCount;

	// Use this for initialization
	void Start () {
		frameCount = 0;
        
        int randomNumber;
        bool randomSwitch;
        randomNumber = Random.Range(0,2);
        if ( randomNumber == 1 ) {
            randomSwitch = true;
        }
        else {
            randomSwitch = false;
        }
        randomNumber = Random.Range(1,10);
        RandomMessage(randomNumber, randomSwitch);
	}
    
    void RandomMessage(int number, bool alter) { // changes message based on random parameters
        if ( number < 4 ) {
            if ( alter ) {
                print(number + " is a low roll");
            }
            else {
                print("You got unlucky with " + number);
            }
        }
        else if ( number < 7 && number > 3 ) {
            if ( alter ) {
                print(number + " is a mid roll");
            }
            else {
                print("You got okay luck with " + number);
            }
        }
        else {
            if ( alter ) {
                print(number + " is a high roll");
            }
            else {
                print("You got lucky with " + number);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        
		if ( stopLight == "Red") { //runs if condition is met
            if ( badDriver ) {
                print("Stop");
            }
            else {
                print("Stopped");
            }
        }
        else if (stopLight == "Yellow") {
            if ( badDriver ) {
                print("Yield");
            }
            else {
                print("Yielded");
            }
        }
        else if (stopLight == "Green") {
            print("Go");
        }
        else { // runs if all connected if & elseif statements above do not meet their condition
            print("Move with caution");
        }
        
        // increases frameCount as the game is running, prints a message on every frame depending on how long the program has been running
        frameCount++;
        if ( frameCount < 1000 ) {
            print("Less than 1000 frames");
        }
        else if ( frameCount >= 1000 && frameCount < 2000 ) {
            print("Between 1000 and 1999 frames");
        }
        else {
            print("2000 frames or above");
        }
        
	}
}
