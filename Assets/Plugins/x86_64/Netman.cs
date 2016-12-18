using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using SimpleJSON;

public class Netman : MonoBehaviour {

	void Start() {
		StartCoroutine(GetText());
	//	StartCoroutine(GetTexture());
	}
		
	string recText = "";
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


				var N = JSON.Parse(recText);
				var versionString = N["songName"].Value;        // versionString will be a string containing "1.0"
				var versionNumber = N["Duration"].AsFloat;      // versionNumber will be a float containing 1.0
				//var name = N["data"]["sampleArray"][2]["name"];// name will be a string containing "sub object"

				string val = N["data"]["sampleArray"][0];      // val contains "string value"
				print (val);

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