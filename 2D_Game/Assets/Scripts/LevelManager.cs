﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckPoint;
    private Rigidbody2D pcRigid;

    private GameObject player;

    // Particles
    public GameObject deathParticle;
    public GameObject respawnParticle;

    // Respawn Delay
    public float respawnDelay;

    // Point Penalty on Death
    public int pointPenaltyOnDeath;

    // Store Gravity Value
    private float gravityStore;

    // Health Bar
    public HealthBar HP;

    // Use this for initialization
	void Start () {
        pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
	}

    public void RespawnPlayer() {
        StartCoroutine( "RespawnPlayerCo" );
    }

    public void CheckPointUpdate(GameObject checkPoint) {
        currentCheckPoint.transform.position = checkPoint.transform.position;
    }

    public IEnumerator RespawnPlayerCo()
    {
        // Generate Death Particle
        Instantiate(deathParticle, pcRigid.transform.position, pcRigid.transform.rotation);
        // Hide Player
        player.SetActive(false);
        player.GetComponent<Renderer>().enabled = false;
        // Gravity Reset
        gravityStore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
        pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        // Point Penalty
        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        // Debug Message
        // Debug.Log("Player Respawn");
        // Respawn Delay
        yield return new WaitForSeconds(respawnDelay);
        // Gravity Restore
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        // Match Players transform position
        pcRigid.transform.position = currentCheckPoint.transform.position;
        // Show Player
        player.SetActive(true);
        player.GetComponent<Renderer>().enabled = true;
        // Spawn Player
        Instantiate(respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
        // Reset HP Bar
        HP.ResetHealth();
        
    }

	// Update is called once per frame
	void Update () {
		
	}
}
