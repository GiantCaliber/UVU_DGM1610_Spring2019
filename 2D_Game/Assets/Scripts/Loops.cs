using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

    private int bottles = 100;

	// Use this for initialization
	void Start () {

        // For Loop test
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
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
