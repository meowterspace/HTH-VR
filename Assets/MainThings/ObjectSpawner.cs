using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {
	float lastTime = 0;

    [SerializeField]
    GameObject[] gifts;

    [SerializeField]
    Transform[] points;

    private GameObject player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

	void Update () {
		//if (Input.GetKeyDown(KeyCode.A))
		if (lastTime + 1 < Time.time) { 
			FireGift (Random.Range (0, points.Length));
			lastTime = Time.time;
		}
	}
	
	void FireGift(int i) {
        GameObject gift = (GameObject)Instantiate(gifts[i], new Vector3(points[0].position.x, points[0].position.y, Random.Range(points[0].position.z, points[1].position.z)), Quaternion.identity);
        gift.AddComponent<PrezzieLogic>();
    }
}
