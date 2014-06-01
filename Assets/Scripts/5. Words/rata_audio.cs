using UnityEngine;
using System.Collections;

public class rata_audio : MonoBehaviour {

	public AudioClip sound;
	// Update is called once per frame
	void Update () {
		if(Input.touchCount>=0){
			for(int i=0;i<Input.touchCount;i++){
				if(this.guiTexture.HitTest(Input.GetTouch(i).position)){
					if(Input.GetTouch(i).phase==TouchPhase.Began){
						audio.PlayOneShot(sound);
					}
				}
			}
		}
	}
}
