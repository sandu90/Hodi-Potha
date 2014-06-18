using UnityEngine;
using System.Collections;

public class ala_sound : MonoBehaviour {
	
	public AudioClip sound;
	// Update is called once per frame
	void Update () {
		
		for(int i=0;i<Input.touchCount;i++){
			if(this.guiTexture.HitTest(Input.GetTouch(i).position)){
				if(Input.GetTouch(i).phase==TouchPhase.Began){
					audio.PlayOneShot(sound);

				}
			}
		}

		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit();
		
	}
}
