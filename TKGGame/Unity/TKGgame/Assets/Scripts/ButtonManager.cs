using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour {

	public void PressButton() {
		GameManager.MoveToNextScene ();
		Debug.Log("Press!!");
	}

	public void ResetButton() {
		Debug.Log ("Push");
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
