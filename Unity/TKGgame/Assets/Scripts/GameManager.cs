using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
	public Text _text;
	private bool _onetouch = false;
	private bool _failed = false;
	private bool _clear = false;
	public AudioClip _clearSound;
	public static int SceneNum;
	public EggController egg;
	public GameObject button;

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
		if(_clear) {
			_clear = false;
			FindObjectOfType<AudioSource>().PlayOneShot(_clearSound);

        }
		if (Input.GetKeyDown(KeyCode.Return) && _clear) {
			Debug.Log(SceneNum);
			MoveToNextScene();
		}
		if(Input.GetKeyDown(KeyCode.Return) && _failed ){
			SceneManager.LoadScene(SceneNum);
		}
	}

	public static void MoveToNextScene(){
		try{
			SceneNum++;
			SceneManager.LoadScene(SceneNum);
		}catch{
			SceneNum = 0;
			SceneManager.LoadScene (SceneNum);
		}
	}

	public static void MoveToNextScene(int _sceneNum){
		try{
			SceneManager.LoadScene(_sceneNum);
		}catch{
			Debug.Log("Error!");
		}
	}

	public void TkgSuccess() {
		_clear = true;
		_text.text = "Hit\n\nPress Enter";

	}

	public void TkgFailed() {
		_text.text = "Failed";
		_failed = true;

	}

		
}