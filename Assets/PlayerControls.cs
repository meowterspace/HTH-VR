using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    [SerializeField]
    GameObject ball;

    float last;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        //if (Input.GetKeyDown(KeyCode.Space))
        if (last + 1 < Time.time) {
            Instantiate(ball, transform.position, Quaternion.identity);
            last = Time.time;
        }
    }
}
