using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

    // private int bottles = 100;

	// Use this for initialization
	void Start () {

        /* For Loop test
        for ( int i = 0; i < bottles; i++ ) {
            print( ( i + 1 ) + " bottle(s)" );
        }

        // While Loop test
        while ( bottles >= 0 ) {
            print(bottles + " trash remaining");
            bottles--;
            if (bottles == -1) {
                print("All trash has been eliminated");
            }
        } */

        // Do While Loop
        // bool shouldContinue = false;

        //do { // always will run once, regardless if while statement is false. will loop if while statement is true
        //    print( "Hello World" );
        //} while ( shouldContinue == true );

        // ForEach Loop
        string[] strings = new string[3];

        strings[0] = "First";
        strings[1] = "Second";
        strings[2] = "Third";

        // runs through the array, item is used to store array data
        foreach ( string item in strings ) {
            print (item);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
