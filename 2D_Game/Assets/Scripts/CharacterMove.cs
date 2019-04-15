using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

    // player movement variables
    public float moveSpeed;
    public float jumpHeight;
    
    // player grounded variables
    private bool grounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    // player scale for flip
    private Vector3 scale;

    // non-stick player
    public float moveVelocity;

    // animator
    public Animator animator;
    
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        scale = transform.localScale;
        animator.SetBool("isWalking", false);
        animator.SetBool("isJumping", false);
    }
    
    void FixedUpdate () {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
	
	// Update is called once per frame
	void Update () {

        // jump movement
        if (Input.GetKeyDown(KeyCode.W) && grounded) { //jump
            Jump();
        }

        // non-stick player
        moveVelocity = 0f;

        // x axis movement
        if (Input.GetKey(KeyCode.D)) { //right movement
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = moveSpeed;
            animator.SetBool("isWalking", true);
            transform.localScale = new Vector3(scale.x, scale.y, scale.z);
        }
        else if (Input.GetKeyUp(KeyCode.D))
            animator.SetBool("isWalking", false);

        if (Input.GetKey(KeyCode.A)) { //left movement
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = -moveSpeed;
            animator.SetBool("isWalking", true);
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
        }
        else if (Input.GetKeyUp(KeyCode.A))
            animator.SetBool("isWalking", false);



        // player flip
        //if (GetComponent<Rigidbody2D>().velocity.x > 0)
            
        //else if (GetComponent<Rigidbody2D>().velocity.x < 0)
            

        
	}
    
    void Jump () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        animator.SetBool("isJumping", true);
    }
}
