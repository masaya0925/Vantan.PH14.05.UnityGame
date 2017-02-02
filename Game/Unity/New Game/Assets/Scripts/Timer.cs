using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {


	public GameObject _winner;

	[SerializeField]
	private Text _timer;

	private float _time = 60f;


	void Start () {

	}
	
	void Update () {
		_time -= Time.deltaTime;

		if (_time < 0) {
			_time = 0;
			_winner.GetComponent<Text>().text = "Draw";
		}
		_timer.GetComponent<Text>().text = ((int)_time).ToString ();
	}
}
