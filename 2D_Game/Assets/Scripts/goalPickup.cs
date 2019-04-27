using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalPickup : MonoBehaviour {

    public GameObject menu;
    public GameObject controller;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            menu.SetActive(true);
            controller.SetActive(false);
            Destroy(gameObject);
        }
    }
}
