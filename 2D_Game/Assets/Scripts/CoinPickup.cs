using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : GenericPickup {
    
    public int coinValue;
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag ==  "Player") {
            print("Coin Collected");
            Destroy(gameObject);
        }
    }
}
