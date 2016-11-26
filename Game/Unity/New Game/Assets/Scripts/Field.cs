using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour {



	void OnTriggerExit(Collider col) {
		Destroy(col.gameObject);

		if(col.gameObject.name == "Player1"){
			Debug.Log("P2 Win!");
		} else if (col.gameObject.name == "Player2"){
			Debug.Log("P1 Win!");
		}
	}
}
