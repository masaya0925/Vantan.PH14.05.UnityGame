using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
	public AudioClip _success;
	public AudioClip _failed;


	public void Success() {
		FindObjectOfType<AudioSource>().PlayOneShot(_success);
	}

	public void Failed() {
		FindObjectOfType<AudioSource>().PlayOneShot(_failed);
	}
}
