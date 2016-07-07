using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour {

	public void PressButton() {

		SceneManager.LoadScene("Stage1");
		Debug.Log("Press!!");
	}
}
