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
	private static bool _isPlaying = false;
	private static float _TimeScore = 0;

	public static float TimeScore{
		get{
			return _TimeScore;
		}
	}

    void Awake() {
        _namaEgg.SetActive(false);
    }

	void Start(){
		StartCoroutine (CountTime ());
	}

    void Update () {
		if (!_onetouch) {
			if (Input.GetMouseButton (0)) {
				
				Vector3 screenPoint = new Vector3( Input.mousePosition.x, 500, 18);
				var screenToWorld = Camera.main.ScreenToWorldPoint (screenPoint);
				egg.transform.position = new Vector3 (screenToWorld.x, egg.transform.position.y, egg.transform.position.z);

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
		Timer ();
	}

	public static void MoveToNextScene(int _sceneNum){
		try{
			SceneManager.LoadScene(_sceneNum);
		}catch{
			Debug.Log("Error!");
		}
		Timer ();
	}


	private static void Timer(){
		if (SceneNum == 1 || SceneNum == 10) {
			_isPlaying = !_isPlaying;
		}
		if(SceneNum == 2){
			Debug.Log( "Time = " + (int)TimeScore + "秒");
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

	private IEnumerator CountTime(){
		while(_isPlaying) {
			_TimeScore += Time.deltaTime;
			yield return null;
		}
	}

		
}