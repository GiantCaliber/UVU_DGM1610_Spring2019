using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderShift : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    private PolygonCollider2D[] colliders;
    private int colliderIndex = 0;

    public void SetColliderForSprite(int spriteNum) {
        colliders[colliderIndex].enabled = false;
        colliderIndex = spriteNum;
        colliders[colliderIndex].enabled = true;
    }
}
