using UnityEngine;
using System.Collections;

public class BarScript : MonoBehaviour {
    public GameObject _futa;
	// Use this for initialization
	void Awake() {
        gameObject.GetComponent<Rigidbody>().useGravity = false;
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision col){
	    if(col.gameObject.tag == "Egg"){
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
