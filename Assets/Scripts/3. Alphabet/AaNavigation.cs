using UnityEngine;
using System.Collections;

//public class AaNavigation : TouchButtonLogic {
public class AaNavigation : MonoBehaviour {

	/*void onTouchBegan() {
		print ("touch began");
		Application.LoadLevel ("Akuru Liyamu1");
	}*/

	void Update () {
		for (int i=0; i<Input.touchCount; i++) {
			if(this.guiTexture.HitTest(Input.GetTouch(i).position)) {
				if(Input.GetTouch(i).phase == TouchPhase.Began) {
					Application.LoadLevel ("Akuru Liyamu1");
				}
			}
		}
	}
}
