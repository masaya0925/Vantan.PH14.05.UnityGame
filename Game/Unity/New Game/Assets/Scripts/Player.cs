using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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
	private AudioClip _syoutotu = null;
	[SerializeField]
	private Player _target = null;

	public float _stackspeed = 0;
	private Rigidbody _rigidbody;
	void Start () {
		_rigidbody = GetComponent<Rigidbody>();
		StartCoroutine(DoubleClickPrevention());


	}

	Vector3 GetForce () {
		var h = Input.GetAxis(_horizontal);
		var v = Input.GetAxis(_vertical);
		return new Vector3(h*_speed, 0,v*_speed);
	}

	void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag == "Player") {
			col.gameObject.GetComponent<AudioSource>().PlayOneShot(_syoutotu);		
		}
	}

	private IEnumerator DoubleClickPrevention() {
		while (true) {
			var force = GetForce ();
			_rigidbody.AddForce (force, ForceMode.Acceleration);
	
			if (Input.GetButton (_stack)) {
				_stackspeed += 5;
				if (_stackspeed >= 40) {
					_stackspeed = 40;
				}
			} else if (_target != null) {
				var dis = _target.transform.position - transform.position;
				var v = dis.normalized * _stackspeed;
				if (v != Vector3.zero) {
					_rigidbody.AddForce (v, ForceMode.VelocityChange);
					_stackspeed = 0;
				}
				yield return new WaitForSeconds (0.5f);
			}
			yield return null;

		}
	}
}

