using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLIPTHETABLEMATE : MonoBehaviour {
    float timemate;
    public int scoreCount = 0;
    // Use this for initialization
    void Start() {
        timemate = Time.time;
        StartCoroutine(poop());
    }

    IEnumerator poop() {
        yield return new WaitForSeconds(30);
        GetComponent<MeshRenderer>().enabled = true;
        yield return new WaitForSeconds(15);
        GetComponent<MeshRenderer>().enabled = false;


    }
}
