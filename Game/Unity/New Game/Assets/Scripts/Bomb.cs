using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : StageObject {

	[SerializeField]
	private float _power;



	private float _radius = 10f;

	[SerializeField]
	private GameObject _effect;

	void Start(){
		
	}

	void OnCollisionEnter(Collision col) {


		Vector3 _bPos = transform.position;


		var stageObjects = GameObject.FindObjectsOfType<StageObject>();
		foreach (var stageObject in stageObjects) {
			if (stageObject == this) { continue;}
			var p = Mathf.Max(0, 1 - ((_bPos - stageObject.transform.position).magnitude / _radius));
			var rigidbody = stageObject.GetComponent<Rigidbody>();
			if (rigidbody != null) {
				rigidbody.AddExplosionForce (_power * p, _bPos, _radius, 5f);
			}
		}
	     var v = Instantiate(_effect, _bPos,Quaternion.identity);
		 Destroy (v, 1); 
		 Destroy (gameObject);
	}

}
