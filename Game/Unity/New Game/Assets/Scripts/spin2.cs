using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin2 : MonoBehaviour {

	private int spin = 10;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	void OnCollisionStay(Collision col){
		Debug.Log("atatta");

		if(col.gameObject.name == "floar"){


		}

	}
}
