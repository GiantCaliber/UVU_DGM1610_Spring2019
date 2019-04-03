using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public Slider healthBar;
    public float maxHealth;
    private float currentHealth;
    public LevelManager levelManager;

    // Use this for initialization
    void Start () {
        // sets health to full and updates health bar on load
        ResetHealth();

	}
	
	// Update is called once per frame
	void Update () {
    }

    // Damage Calculator takes damage and converts it into slider adjustment
    public void DamageCalc(float damageValue) {
        currentHealth -= damageValue;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }
        else if (currentHealth > maxHealth) {
            currentHealth = maxHealth;
        }
        healthBar.value = healthCalc();
        if (currentHealth == 0) {
            levelManager.RespawnPlayer();
        }
    }

    public void ResetHealth () {
        currentHealth = maxHealth;
        healthBar.value = healthCalc();
    }

    float healthCalc() { // calculates health percentage with the intent of 100% being 1.0
        return ( currentHealth / maxHealth );
    }
}
