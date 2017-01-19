using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StackBar : MonoBehaviour {
    public Player _player;
	public Slider _slider;



	void Start () {
		_slider = GameObject.Find("Slider").GetComponent<Slider>();

	}

	//float _stack = _player._stackspeed;
	void Update () {
		 
	}
}
