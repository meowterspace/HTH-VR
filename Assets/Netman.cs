using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class Netman : MonoBehaviour {

	void Start() {
		StartCoroutine(GetText());
	//	StartCoroutine(GetTexture());
	}
	string recText = "";
	string data = "";
	IEnumerator GetText() {
		while (true) {
			UnityWebRequest www = UnityWebRequest.Get ("http://localhost:8000/test.json");
			yield return www.Send ();

			if (www.isError) {
				Debug.Log (www.error);
			} else {
				// Show results as text
				recText = (www.downloadHandler.text);
				Debug.Log (recText);
				// Or retrieve results as binary data
				byte[] results = www.downloadHandler.data;

				data = JsonUtility.FromJson<string> (recText);
				print (data);
			}
			yield return new WaitForSeconds (5);
		}
	}

/*	IEnumerator GetTexture() {
		while (true) {
			UnityWebRequest www = UnityWebRequest.GetTexture (ImagePath);
			yield return www.Send ();

			if (www.isError) {
				Debug.Log (www.error);
			} else {
				Texture myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture;
				this.GetComponent <MeshRenderer> ().sharedMaterial.SetTexture ("_MainTex", myTexture);
			}
		}*/
	
}