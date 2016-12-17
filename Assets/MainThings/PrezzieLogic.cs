using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrezzieLogic : MonoBehaviour {

    private GameObject player;
    const int SPEED = 3;
 

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, SPEED * Time.deltaTime);
	}

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    
}
