using UnityEngine;
using System.Collections;

public class block : MonoBehaviour {

	public AudioClip impact;
	AudioSource audio;

	void Start(){
		audio = GetComponent<AudioSource> ();	}

	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.tag == "block" || other.gameObject.tag == "ground") {
			audio.PlayOneShot (impact, 0.7f);
		}
	}
}
