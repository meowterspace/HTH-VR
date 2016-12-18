using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    float health;

    public List<GameObject> cats = new List<GameObject>();

    public void TakeDamage(float damage) {
        health -= damage;
        //updateHP
    }

    private void Start() {
        foreach(GameObject ob in GameObject.FindGameObjectsWithTag("cat")) {
            cats.Add(ob);
        }
    } 

    //DO PHYSICS CHECKS

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "gift") {
            Destroy(cats[Random.Range(0, cats.Count)]);
            Destroy(collision.gameObject);
        }
    }

}
