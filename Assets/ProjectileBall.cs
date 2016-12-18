using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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
            int count = GameObject.FindObjectOfType<FLIPTHETABLEMATE>().scoreCount++;
            GameObject.Find("textgift").GetComponent<Text>().text = "Evil Gifts Destroyed\n" + (count+1);  
            Destroy(collision.gameObject);
            Destroy(Instantiate(boom, transform.position, Quaternion.identity), 5);
            Destroy(gameObject);
        }
    }
}
