﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

    public LevelManager levelManager;

    void Start() {
        // loading GameObject
        levelManager = FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player") {
            levelManager.RespawnPlayer();
        }
    }
}
