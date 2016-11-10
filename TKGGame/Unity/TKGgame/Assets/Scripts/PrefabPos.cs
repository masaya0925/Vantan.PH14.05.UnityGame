using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabPos : MonoBehaviour {
	public GameObject tvPrefab;
	public GameObject tvDeckPrefab;
	// Use this for initialization
	void Start () {
		Instantiate(tvPrefab);
		Instantiate(tvDeckPrefab);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
