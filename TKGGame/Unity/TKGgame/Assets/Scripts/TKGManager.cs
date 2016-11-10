using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TKGManager : MonoBehaviour {

	public GameObject _namaEgg;
	public GameObject _resetbutton;
	public GameObject _nextbutton;
	public SoundManager _soundManager;

	void Awake() {


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

}
