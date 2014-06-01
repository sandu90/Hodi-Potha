using UnityEngine;
using System.Collections;

public class TouchButton : TouchButtonLogic {

	public AudioClip sound;

	void OnTouchBegan() {
		//print ("I LovE ManaraM");

		audio.PlayOneShot (sound);
	}
}
