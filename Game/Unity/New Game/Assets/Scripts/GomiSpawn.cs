using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GomiSpawn : MonoBehaviour {
    [SerializeField]
	private GameObject _gomi; 
	[SerializeField]
	private GameObject _bomb;
	[SerializeField]
	private float timer; 

	void Start () {
		StartCoroutine(Spawn(5f));
	    
	}
		
	void Update() {
		timer += Time.deltaTime;


	}

	private IEnumerator Spawn(float waitTime) {
		yield return new WaitForSeconds(waitTime);
      while(true){
			var r =	Random.Range(0,5);
			float x = Random.Range(-6.0f,6.0f);
		    float z = Random.Range(-6.0f,6.0f);
			if (r > 1) {
				Instantiate (_gomi, new Vector3 (x, 5, z), Quaternion.identity);
			} else {
				Instantiate (_bomb, new Vector3 (x, 5, z), Quaternion.identity);
			}
			yield return new WaitForSeconds(5f);
	  }

	}
}
