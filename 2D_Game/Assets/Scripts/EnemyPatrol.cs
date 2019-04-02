﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

    // Movement
    public float moveSpeed;
    public bool moveRight;

    // Wall Check
    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;

    // Edge Check
    private bool notAtEdge;
    public Transform edgeCheck;
	
	// Update is called once per frame
	void Update () {
        notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);

        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);

        if ( hittingWall || !notAtEdge ) {
            moveRight = !moveRight;
        }

        if ( moveRight ) {
            transform.localScale = new Vector3(-0.2f, 0.2f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else {
            transform.localScale = new Vector3(0.2f, 0.2f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
	}
}
