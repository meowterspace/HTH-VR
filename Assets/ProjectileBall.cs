using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBall : MonoBehaviour {

    GameObject boom;

    Transform camPos;

	void Start () {
        camPos = Camera.main.transform;
        boom = GameObject.FindObjectOfType<ObjectSpawner>().boom;
    }

    void FixedUpdate () {
        transform.position = transform.position + camPos.forward;
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "gift") {
            Destroy(collision.gameObject);
            Destroy(Instantiate(boom, transform.position, Quaternion.identity), 5);
            Destroy(gameObject);
        }
    }
}
