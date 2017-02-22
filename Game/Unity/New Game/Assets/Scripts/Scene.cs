using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour {

	public void FlatClick() {
		SceneManager.LoadScene("Stage1");
	}

	public void BattleClick() {
		SceneManager.LoadScene("Stage2");
	}
}
