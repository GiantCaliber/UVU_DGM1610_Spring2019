using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

    // player movement variables
    public float moveSpeed;
    public float jumpHeight;
    public bool doubleJump;

    // double jump powerup
    private bool doubleJumpPower;
    
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
        doubleJumpPower = false;

    }
    
    void FixedUpdate () {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        if (grounded)
        {
            doubleJump = false;
            animator.SetBool("isJumping", false);
            moveVelocity = 0f;
        }
    }
	
	// Update is called once per frame
	void Update () {

        // jump movement
        // double jump code
        // non-stick player

        if (Input.GetKeyDown(KeyCode.W) && grounded)
        { //jump
            Jump();
            animator.SetBool("isJumping", true);
        }

        // only works once the doubleJump powerup has been collected
        if (Input.GetKeyDown(KeyCode.W) && !doubleJump && !grounded && doubleJumpPower ) {
            Jump();
            animator.SetBool("isJumping", true);
            doubleJump = true;
        }

        

        // x axis movement
        if (Input.GetKey(KeyCode.D)) { //right movement
            //GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = moveSpeed;
            animator.SetBool("isWalking", true);
            transform.localScale = new Vector3(scale.x, scale.y, scale.z);
        }
        else if (Input.GetKeyUp(KeyCode.D))
            animator.SetBool("isWalking", false);

        if (Input.GetKey(KeyCode.A)) { //left movement
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = -moveSpeed;
            animator.SetBool("isWalking", true);
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
        }
        else if (Input.GetKeyUp(KeyCode.A))
            animator.SetBool("isWalking", false);

        GetComponent<Rigidbody2D>().velocity = new Vector2( moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

        //player fall detection
        //if rigidbody.velocity.y < 0
            //animator plays fall animation



    }
    
    void Jump () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }

    public void DoubleJumpOn () { // what turns on double jump
        doubleJumpPower = true;
    }


}
