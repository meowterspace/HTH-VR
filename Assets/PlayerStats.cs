using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    float health;

    public void TakeDamage(float damage) {
        health -= damage;
        //updateHP
    }

    //DO PHYSICS CHECKS

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "gift") {
            Destroy(collision.gameObject);
        }
    }

}
