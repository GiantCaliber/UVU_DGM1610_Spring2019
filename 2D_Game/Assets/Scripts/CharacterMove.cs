using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

    // player movement variables
    public float moveSpeed;
    public float jumpHeight;
    
    // player grounded variables
    private bool grounded;
    
	// Use this for initialization
	void Start () {
        // Default to true on grounded
		grounded = true;
	}
	
	// Update is called once per frame
	void Update () {
		// x axis movement
        if (Input.GetKey(KeyCode.D)) { //right movement
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else if (Input.GetKey(KeyCode.A)) { //left movement
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        
        // y axis movement
        if (Input.GetKeyDown(KeyCode.W) && grounded ) { //jump
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
        
	}
}
