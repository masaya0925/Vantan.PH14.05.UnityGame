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
    public GameObject _namaEgg;
    void Awake() {
        _namaEgg.SetActive(false);
    }

    void Update () {
		if (!_onetouch) {
			if (Input.GetMouseButton (0)) {
				var screenPoint = Input.mousePosition;
				    screenPoint.z = 18;
				    screenPoint.y = 500;
				var screenToWorld = Camera.main.ScreenToWorldPoint (screenPoint);
				egg.SetPosition(screenToWorld);

			} else if (Input.GetMouseButtonUp (0)) {
				egg.Drop();
				_onetouch = true;
			} 
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
        _namaEgg.SetActive(true);
		_text.text = "Hit\n\nPress Enter";
        FindObjectOfType<AudioSource>().PlayOneShot(_clearSound);
    }

    public void TkgFailed() {
		_text.text = "Failed";
		_failed = true;

	}

		
}