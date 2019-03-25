using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoisonPickup : MonoBehaviour {

    public float damage;

    public HealthBar HP; // assign GameObject in inspecter to enable calling DamageCalc

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") // if contact is made, take damage and enemy despawns
        {
            HP.DamageCalc(damage);
            Destroy(gameObject);
        }
    }
}
