﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleFollow : MonoBehaviour {

	public Transform target;
    
    void LateUpdate() {
        transform.position = target.position;
    }
}
