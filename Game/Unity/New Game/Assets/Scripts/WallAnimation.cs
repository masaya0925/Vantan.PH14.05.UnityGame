using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAnimation : MonoBehaviour {

	private float x = 0f;
	private float z = 0f;

	[SerializeField]
	private GameObject _up;
	[SerializeField]
	private GameObject _down;
	[SerializeField]
	private GameObject _right;
	[SerializeField]
	private GameObject _left;

	private bool _atatta = false;

	void Start () {
	  	

	}

	void OnTriggerEnter(Collider col){
		if (_atatta) {
			_atatta = false;
		} else {
			_atatta = true;
		}
	}




	void Update(){
		StartCoroutine(WallMove(10f));
	}

	private IEnumerator WallMove(float _waitTime){
		yield return new WaitForSeconds(_waitTime);
		if (!_atatta) {
			x += 0.05f;
			z += 0.05f;
			_up.transform.localPosition = new Vector3 (x, 0.5f, 9.9f);
			_down.transform.localPosition = new Vector3(-x, 0.5f, -9.9f);
			_right.transform.localPosition = new Vector3(9.9f, 0.5f, z);
			_left.transform.localPosition = new Vector3(-9.9f, 0.5f, -z);
		} else {
			x -= 0.05f;
			z -= 0.05f;
			_up.transform.localPosition = new Vector3(x, 0.5f, 9.9f);
			_down.transform.localPosition = new Vector3(-x, 0.5f, -9.9f);
			_right.transform.localPosition = new Vector3(9.9f, 0.5f, z);
			_left.transform.localPosition = new Vector3(-9.9f, 0.5f, -z);

		}
	}
}
