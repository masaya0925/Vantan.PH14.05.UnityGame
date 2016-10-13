using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour {

	public PlayerManager _pm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col) {

		Debug.Log(col.gameObject.name);

		col.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3(-1*_pm._stackspeed,-1*_pm._stackspeed,-1*_pm._stackspeed);

	}

}
