using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

		StartCoroutine(LoadDataItarator());

	}

	private IEnumerator LoadDataItarator() {

		var www = new WWW("localhost");
		yield return www;
		Debug.Log(www.text);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
