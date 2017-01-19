using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAnimation : MonoBehaviour {

	[SerializeField]
	private GameObject _Uwall;
	[SerializeField]
	private GameObject _Dwall;

	private float x = 0f;

	void Start () {
	  	

	}

	void OnTriggerEnter(Collider col){
		x -= 0.1f;
		_Uwall.transform.localPosition = new Vector3(x, 0.48f, 9.89f);
	}


	void Update(){
		x += 0.01f;
		_Uwall.transform.localPosition = new Vector3(x, 0.48f, 9.89f);
	}
		
}
