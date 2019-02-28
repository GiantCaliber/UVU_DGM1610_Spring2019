using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
    
    public string suspect;
    
    public string weapon;
    
    public string room;

	// Use this for initialization
	void Start () {
        
		MurderMystery(suspect, weapon);
        
	}
    
    void MurderMystery (string suspect, string weapon) {
        switch(suspect){
            case "Mr.K":
                print("In room with R");
                break;
            case "Mr.R":
                print("In noom with K");
                break;
            case "Mr.F":
                print("On phone with M");
                break;
            default:
                print(" I don't know");
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
