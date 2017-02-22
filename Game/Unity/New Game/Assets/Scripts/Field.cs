using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Field : MonoBehaviour {

	public UI _timer;


	public bool _isGameOver = false;

	void OnTriggerExit(Collider col) {
		if ( _isGameOver) {
			return;
		}
		if(col.gameObject.name == "Player1" || col.gameObject.name == "Player2"){
			_isGameOver = true;

			if(col.gameObject.name == "Player1"){
				_timer._winner.GetComponent<Text>().text = "Player 2 Win!!";
				StartCoroutine(BacktoTitle(2));
			} else if (col.gameObject.name == "Player2"){
				_timer._winner.GetComponent<Text>().text = "Player 1 Win!!";
				StartCoroutine(BacktoTitle(2));
			}
		}
		Destroy(col.gameObject);
	}
	void Update() {
		if(!_isGameOver && _timer._time <= 0) {
			_timer._winner.GetComponent<Text>().text = "Draw";
			StartCoroutine(BacktoTitle(2));
		}
	}
	private IEnumerator BacktoTitle(float _waittime) {
		yield return new WaitForSeconds(_waittime);
		SceneManager.LoadScene("Title");
	}

}
