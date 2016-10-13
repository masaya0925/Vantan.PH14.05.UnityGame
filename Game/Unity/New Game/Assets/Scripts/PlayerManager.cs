using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {


	public float _stackspeed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(gameObject.GetComponent<Rigidbody>().velocity);
		if(Input.GetKey(KeyCode.W)) {
			gameObject.GetComponent<Rigidbody>().AddForce(0,0,10,ForceMode.Acceleration);

		}
		if(Input.GetKey(KeyCode.A)) {
			gameObject.GetComponent<Rigidbody>().AddForce(-10,0,0,ForceMode.Acceleration);

		}
		if(Input.GetKey(KeyCode.S)) {
			gameObject.GetComponent<Rigidbody>().AddForce(0,0,-10,ForceMode.Acceleration);

		}
		if(Input.GetKey(KeyCode.D)) {
			gameObject.GetComponent<Rigidbody>().AddForce(10,0,0,ForceMode.Acceleration);

		}
		if(Input.GetKey(KeyCode.Space)){
			_stackspeed++;
			if(_stackspeed >= 25){
				_stackspeed = 25;
			} 
			//Debug.Log("_stackspeed = " + _stackspeed);

		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			if (Input.GetKey (KeyCode.W)) {
				gameObject.GetComponent<Rigidbody> ().AddForce(0, 0, _stackspeed,ForceMode.VelocityChange);

			}
			if (Input.GetKey (KeyCode.A)) {
				gameObject.GetComponent<Rigidbody> ().AddForce(-_stackspeed, 0, 0,ForceMode.VelocityChange);

			}
			if (Input.GetKey (KeyCode.S)) {
				gameObject.GetComponent<Rigidbody> ().AddForce(0, 0, -_stackspeed,ForceMode.VelocityChange);

			}
			if (Input.GetKey (KeyCode.D)) {
				gameObject.GetComponent<Rigidbody> ().AddForce(_stackspeed, 0, 0,ForceMode.VelocityChange);
			
			}
			_stackspeed = 0;
		}
	}
}
