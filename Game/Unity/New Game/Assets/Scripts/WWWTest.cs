using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WWWTest : MonoBehaviour {
	
	private MeshRenderer _meshrenderer1; 
	private MeshRenderer _meshrenderer2;

	private GameObject _cube1;
	private GameObject _cube2;



	// Use this for initialization
	void Start () {

		StartCoroutine(CubeCreationIterator());

	}

	private IEnumerator CubeCreationIterator() {

		_cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		_cube1.transform.Translate(-1,0,0);
		_cube1.transform.Rotate(0,180,0);
		var www1 = new WWW("http://unity-chan.com/images/imageLicenseLogo.png");
		_meshrenderer1 = _cube1.GetComponent<MeshRenderer>();


		_cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		_cube2.transform.Translate(1,0,0);
		_cube2.transform.Rotate (0,180,0);
		_meshrenderer2 = _cube2.GetComponent<MeshRenderer>();

		yield return www1;
		_meshrenderer1.material.mainTexture = www1.texture;

		var www2 = new WWW ("http://unity-chan.com/images/imageUnityOk02.png");
		yield return www2;
		_meshrenderer2.material.mainTexture = www2.texture;
	}


	// Update is called once per frame
	void Update () {

	}
}
