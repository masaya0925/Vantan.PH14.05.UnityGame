using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoge : MonoBehaviour {

	[SerializeField]
	private GameObject _hoge;
	private Rigidbody _rb;

	[SerializeField]
	private float _power;

	void Start () {
		_rb = GetComponent<Rigidbody>();
	}


	void Update () {
		_rb.AddForce (new Vector3 (0, 0, 1), ForceMode.Acceleration);
		if(Input.GetKeyDown(KeyCode.Space)){
			_rb.AddForce(new Vector3(0,_power,0),ForceMode.Force);

		}
	}

	void OncollisionEnter(Collision col) {
		Destroy (gameObject);
	}
}

   