using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootPickup : MonoBehaviour {

    // here to get access to method DoubleJumpOn
    public playerShoot powerUp;

    public GameObject pickUpParticle;

    // added score for obtaining powerup
    public int score;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            powerUp.ShootOn();
            Instantiate(pickUpParticle, other.transform.position, other.transform.rotation);
            ScoreManager.AddPoints(score);
            Destroy(gameObject);
        }
    }
}
