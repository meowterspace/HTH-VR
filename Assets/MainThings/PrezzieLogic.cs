using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrezzieLogic : MonoBehaviour {


    private GameObject player;
    const int SPEED = 3;
 

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        int myBase = Random.Range(-10, 10);
        GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(myBase,myBase+5), Random.Range(myBase, myBase + 5), Random.Range(myBase, myBase + 5)), ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, SPEED * Time.deltaTime);
	}
    
   

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    
}
