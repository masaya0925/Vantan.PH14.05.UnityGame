﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EggController : MonoBehaviour {
	public GameManager mng;
	private bool _oneTouch = false;
	void Awake () {
		gameObject.GetComponent<Rigidbody>().useGravity = false;
	}

	public void SetPosition(Vector3 newPosition) {
		gameObject.transform.position = newPosition;
	}

	public void Drop() {
		gameObject.GetComponent<Rigidbody> ().useGravity = true;
    }

	void Update() {
		if(!_oneTouch){
			if (Input.GetMouseButton (0)) {

				Vector3 screenPoint = new Vector3( Input.mousePosition.x, 500, 18);
				var screenToWorld = Camera.main.ScreenToWorldPoint (screenPoint);
				transform.position = new Vector3 (screenToWorld.x, transform.position.y, transform.position.z);

			} else if (Input.GetMouseButtonUp (0)) {
				 Drop();
				_oneTouch = true;
			} 
		}
	}
		
	void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag == "Dish"){
			mng.TkgSuccess();
			Destroy(this.gameObject);
	    }
		if(col.gameObject.tag == "Floar"){
			mng.TkgFailed ();
			Destroy(this.gameObject);
		}
		if(col.gameObject.tag == "Table") {
			mng.TkgFailed();
			Destroy(this.gameObject);

		}
		if(col.gameObject.tag == "Bar"){
			mng.TkgFailed();
			Destroy(this.gameObject);
		}
   }
}