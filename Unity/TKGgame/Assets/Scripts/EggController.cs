using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EggController : MonoBehaviour {
	public GameManager mng;
	public GameObject _egg;
	void Awake () {
		gameObject.GetComponent<Rigidbody>().useGravity = false;
		_egg.SetActive(false);
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
			_egg.SetActive(true);
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