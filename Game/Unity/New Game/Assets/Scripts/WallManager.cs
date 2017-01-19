using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour {
	
	[SerializeField]
	private GameObject _wall;

	private float _timer;
	private float _x = 16f;

    void Start () {
    
		StartCoroutine(WallShrinking(0f));
    }


    void Update () {
		
		_timer += Time.deltaTime;

	}

	private IEnumerator WallShrinking(float waitTimes) {
		 yield return new WaitForSeconds(waitTimes);
		while (_x > 5) {
		       _x -= 0.01f;
			   _wall.transform.localScale = new Vector3 (_x, 1, 0.2f);
		   if (_x == 0) {
			   Destroy (_wall);
			}
			yield return null;
		}
	}
}
