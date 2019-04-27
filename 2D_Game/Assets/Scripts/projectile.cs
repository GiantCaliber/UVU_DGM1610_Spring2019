using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {

    public float speed;

    public float timeOut;

    public GameObject player;

    public GameObject enemyDeath;

    public GameObject projectileParticle;

    public int pointsForKill;

    private Vector3 scale;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");

        scale = transform.localScale;

        // enemyDeath = Resources.Load("Prefabs/Death_PS") as GameObject;

        // projectileParticle = Resources.Load("Prefabs/Respawn_PS") as GameObject;

        if (player.transform.localScale.x < 0)
        {
            speed = -speed;
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
        }

        Destroy(gameObject, timeOut);
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2 (speed, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other) {
        // Destroys enemy on contact with projectile. Adds points
        if (other.tag == "Enemy") {
            Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            ScoreManager.AddPoints(pointsForKill);
            Destroy(gameObject);
        }
        else if (other.tag == "Ground") {
            Destroy(gameObject);
            Instantiate(projectileParticle, transform.position, transform.rotation);
            
        }

        // Instantiate (projectileParticle, transform.position, transform.rotation);
        // Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D other) {

    }
}
