using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : StageObject {
	[SerializeField]
	private float _speed = 10;
	[SerializeField]
	private string _horizontal = "Horizontal";
	[SerializeField]
	private string _vertical = "Vertical";
	[SerializeField]
	private string _stack = "Stack";
	[SerializeField]
	private AudioClip _syoutotu;
	public float _stackspeed = 0;
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
		
		var force = GetForce ();
		_rigidbody.AddForce (force, ForceMode.Acceleration);

		if (Input.GetButton(_stack)) {
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
	}

	void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag == "Player") {
			col.gameObject.GetComponent<AudioSource>().PlayOneShot(_syoutotu);		
		}
	}
}

