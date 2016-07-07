using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
	public Text _text;
	public bool _onetouch = false;
	public bool _clear = false;
	public EggController egg;

	void Update () {
		if (!_onetouch) {
			if (Input.GetMouseButton (0)) {
				var screenPoint = Input.mousePosition;
				    screenPoint.z = 18;
				    screenPoint.y = 320;
				var screenToWorld = Camera.main.ScreenToWorldPoint (screenPoint);
				egg.SetPosition(screenToWorld);

			} else if (Input.GetMouseButtonUp (0)) {
				egg.Drop();
				_onetouch = true;
			} 
		}
		if (Input.GetMouseButtonDown(0) && _clear) {

			SceneManager.LoadScene("Stage2");
		}
	}

	public void TkgSuccess() {
		_clear = true;
		_text.text = "Hit";

	}

	public void TkgFailed() {
		_text.text = "Failed";


	}

		
}