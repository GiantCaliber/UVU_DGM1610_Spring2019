using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour {

    public float heal;
    public int scoreRaise;

    public HealthBar HP; // assign GameObject in inspecter to enable calling DamageCalc

    public LevelManager LevelManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") // if contact is made, take damage and enemy despawns
        {
            HP.DamageCalc(-heal);
            Destroy(gameObject);
            ScoreManager.AddPoints(scoreRaise);
            LevelManager.CheckPointUpdate(gameObject);
        }
    }
}
