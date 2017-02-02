using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Field : MonoBehaviour {

	public Timer _timer;


	void OnTriggerExit(Collider col) {
		Destroy(col.gameObject);

		if(col.gameObject.name == "Player1"){
			_timer._winner.GetComponent<Text>().text = "Player 2 Win!!";

		} else if (col.gameObject.name == "Player2"){
			_timer._winner.GetComponent<Text>().text = "Player 1 Win!!";
		}
	}
}
