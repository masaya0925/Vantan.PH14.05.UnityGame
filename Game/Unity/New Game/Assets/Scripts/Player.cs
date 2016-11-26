using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour {
	[SerializeField]
	private float _speed = 10;
	[SerializeField]
	private string _horizontal = "Horizontal";
	[SerializeField]
	private string _vertical = "Vertical";
	[SerializeField]
	private string _stack = "Stack";
	private float _stackspeed = 0;
	private Rigidbody _rigidbody;

	void Start () {
		_rigidbody = GetComponent<Rigidbody>();

	}

	Vector3 GetForce ()
	{
		var h = Input.GetAxis(_horizontal);
		var v = Input.GetAxis(_vertical);
		return new Vector3(h*_speed, 0,v*_speed);
	}
	
	void Update () {
		var force = GetForce();
		_rigidbody.AddForce(force,ForceMode.Acceleration);

	  	if (Input.GetAxis(_stack)) {
			_stackspeed++;
			if (_stackspeed >= 25) {
			    _stackspeed = 25;
			}

		} else {
			var v = force.normalized * _stackspeed;
			if (v != Vector3.zero) {
				_rigidbody.AddForce (v, ForceMode.VelocityChange);
				_stackspeed = 0;
			}
		}
			

//		if (Input.GetKeyUp (KeyCode.Space)) {
//			
//			if (Input.GetKey (KeyCode.W)) {
//				_rigidbody.AddForce(0, 0, _stackspeed,ForceMode.VelocityChange);
//
//			}
//			if (Input.GetKey (KeyCode.A)) {
//				_rigidbody.AddForce(-_stackspeed, 0, 0,ForceMode.VelocityChange);
//
//			}
//			if (Input.GetKey (KeyCode.S)) {
//				_rigidbody.AddForce(0, 0, -_stackspeed,ForceMode.VelocityChange);
//
//			}
//			if (Input.GetKey (KeyCode.D)) {
//				_rigidbody.AddForce(_stackspeed, 0, 0,ForceMode.VelocityChange);
//
//			}
//			_stackspeed = 0;
//		}
	}
}
