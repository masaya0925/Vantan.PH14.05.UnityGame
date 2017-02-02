using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageRotate : MonoBehaviour {


	[SerializeField]
	private int _vector = 100;

	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay(Collision col) {
		if(col.gameObject.tag == "Player") {
			var v = col.transform.position - transform.position;
			var c = Vector3.Cross(v.normalized,new Vector3(0, 1, 0));
			col.gameObject.GetComponent<Rigidbody>().AddForce(c*_vector,ForceMode.Acceleration);
			Debug.Log (c);
		}
	}

}