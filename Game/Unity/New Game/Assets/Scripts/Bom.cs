using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bom : MonoBehaviour {

	private Collider[] hitColliders;
	public float _blastRadius;
	public float _explosionPower;
	public LayerMask _explosionLayer;

	void OnCollisionEnter(Collision col) {


	}

	void Explosion(Vector3 explosionPoint) {
		hitColliders = Physics.OverlapSphere(explosionPoint,_blastRadius,_explosionLayer);

		foreach(Collider hitCol in hitColliders) {
			if(hitCol.GetComponent<Rigidbody>() != null){
				hitCol.GetComponent<Rigidbody>().AddExplosionForce(_explosionPower,explosionPoint,_blastRadius,1,ForceMode.Force);
			}

		}


	}

}
