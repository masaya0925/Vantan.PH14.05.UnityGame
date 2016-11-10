using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour {

	public void PressButton() {
		GameManager.MoveToNextScene ();
	}

	public void ResetButton() {
		GameManager.MoveToNextScene(GameManager.SceneNum);
	}

	public void BackButton() {
		GameManager.SceneNum = 0;
		SceneManager.LoadScene(GameManager.SceneNum);

	}

	public void NextScene(){
		GameManager.SceneNum++;
		GameManager.MoveToNextScene(GameManager.SceneNum);
	}

}
