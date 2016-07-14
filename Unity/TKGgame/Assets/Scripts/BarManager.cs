using UnityEngine;
using System.Collections;

public class BarManager : MonoBehaviour {

	[SerializeField]
	private float delay;

	private float timer;
	private Animator animator;
	private IEnumerator anime() {
		yield return new WaitForSeconds(delay);

		animator.enabled = true;
	}
    
	void Awake() {
		animator = gameObject.GetComponent<Animator>();
		animator.enabled = false;

		StartCoroutine (anime());
	}
	// Update is called once per frame
	void Update () {
//		timer += Time.deltaTime;
//		if(timer > delay) {
//			if(animator.enabled != true){
//			Debug.Log(Time.time);
//			Debug.Log(delay);
//			}
//			animator.enabled = true;
//		}
	}
}
