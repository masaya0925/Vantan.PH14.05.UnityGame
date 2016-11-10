using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
	public Text _text;
	public static int SceneNum;
	public GameObject button;
    public GameObject _namaEgg;
	public GameObject _resetbutton;
	public GameObject _nextbutton;
	private static bool _isPlaying = false;
	private static float _TimeScore = 0;
	public SoundManager _soundManager;
	public static float TimeScore{
		get{
			return _TimeScore;
		}
	}

    void Awake() {
        _namaEgg.SetActive(false);
		_resetbutton.SetActive(false);
		_nextbutton.SetActive(false);

    }

	void Start(){
		StartCoroutine (CountTime ());
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
		if(SceneNum == 10){
		   Debug.Log( "Time = " + (int)TimeScore + "秒");
		}
	}

	public void TkgSuccess() {
        _namaEgg.SetActive(true);
		_resetbutton.SetActive(true);
		_nextbutton.SetActive(true);
		_text.text = "Success!!";
		_soundManager.Success();
    }

    public void TkgFailed() {
		_text.text = "Failed...";
		_resetbutton.SetActive(true);
		_soundManager.Failed();

	}

	private IEnumerator CountTime(){
		while(_isPlaying) {
			_TimeScore += Time.deltaTime;
			yield return null;
		}
	}

		
}