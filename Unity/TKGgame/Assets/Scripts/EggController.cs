using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EggController : MonoBehaviour {
	public GameManager mng;
	public Material _tkg;
	void Awake () {
		gameObject.GetComponent<Rigidbody>().useGravity = false;
	}
	public void SetPosition(Vector3 newPosition) {
		gameObject.transform.position = newPosition;
	}

	public void Drop() {
		gameObject.GetComponent<Rigidbody> ().useGravity = true;
    }

	void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag == "Dish"){
			mng.TkgSuccess();

			Destroy(this.gameObject);
			col.gameObject.GetComponent<Renderer> ().material = _tkg;
	    }
		if(col.gameObject.tag == "Floar"){
			mng.TkgFailed ();

			Destroy(this.gameObject);
		}
  }
}