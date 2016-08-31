using UnityEngine;
using System.Collections;

public class WindScript : MonoBehaviour {

	public GameObject Egg;
	public int _windpower;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col){
		
		if(col.gameObject.tag == "Egg") {
			Debug.Log("Hit");
			StartCoroutine (WindBreathe ());
		}

	}
	private IEnumerator WindBreathe() {
		float MaxTime = 1f;
		for (float time = 0; time < MaxTime; time += Time.deltaTime) {
			Egg.GetComponent<Rigidbody>().AddForce(new Vector3((time/MaxTime)* _windpower, 0, 0), ForceMode.Force);
			Debug.Log ((time/MaxTime)* _windpower + " is power , " + time + " is time.");
			yield return null;
		}

    }



}

   