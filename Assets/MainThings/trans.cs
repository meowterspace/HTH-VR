using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trans : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.A))
    		GetComponent<MeshRenderer>().material.color = new Color (1, 1, 1, 0);

    }
}
