using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	public Player _player1;

	public Player _player2;

	public float _time = 60f;

	public GameObject _winner;

	[SerializeField]
	private Text _timer;
	[SerializeField]
	private Slider _sliderP1;
	[SerializeField]
	private Slider _sliderP2;

	void Start () {

	}
	
	void Update () {

		_sliderP1.value = _player1._stackspeed / 40;
		_sliderP2.value = _player2._stackspeed / 40;

		_time -= Time.deltaTime;

		if (_time <= 0) {
			_time = 0;
		}
		_timer.text = ((int)_time).ToString ();
	}
}
