using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBall : MonoBehaviour {


    Transform camPos;

	void Start () {
        camPos = Camera.main.transform;
    }

    void FixedUpdate () {
        transform.position = transform.position + camPos.forward;
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "gift") {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
