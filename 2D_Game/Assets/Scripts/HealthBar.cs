using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public Slider healthBar;
    public float maxHealth;
    private float currentHealth;

	// Use this for initialization
	void Start () {
        // sets health to full on load
        maxHealth = 10f;
        currentHealth = maxHealth;
        // converts into slider value
        healthBar.value = healthCalc();
	}
	
	// Update is called once per frame
	void Update () {
    }

    // Damage Calculator takes damage and converts it into slider adjustment
    public void DamageCalc(float damageValue) {
        currentHealth -= damageValue;
        healthBar.value = healthCalc();
    }

    float healthCalc() { // calculates health percentage with the intent of 100% being 1.0
        return ( currentHealth / maxHealth );
    }
}
