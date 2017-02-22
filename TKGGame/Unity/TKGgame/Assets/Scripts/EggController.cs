using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EggController : MonoBehaviour {
	public TKGManager _tkg;

	[SerializeField]
	private GameObject _crashEgg;
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

		Vector3 _ePos = transform.position;

		if(col.gameObject.tag == "Dish"){
			_tkg.TkgSuccess();
			Destroy(this.gameObject);
	    }
		if(col.gameObject.tag == "Floar"){
			_tkg.TkgFailed ();
			Destroy(this.gameObject);
			var v = Instantiate(_crashEgg, _ePos, Quaternion.identity);
			Destroy(v,5);
		}
		if(col.gameObject.tag == "Table") {
			_tkg.TkgFailed();
			Destroy(this.gameObject);
			var v = Instantiate(_crashEgg, _ePos, Quaternion.identity);
			Destroy(v,5);
		}
		if(col.gameObject.tag == "Bar"){
			_tkg.TkgFailed();
			Destroy(this.gameObject);
			var v = Instantiate(_crashEgg, _ePos, Quaternion.identity);
			Destroy(v,5);
		}
   }
}