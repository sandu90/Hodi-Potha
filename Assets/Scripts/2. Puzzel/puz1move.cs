using UnityEngine;
using System.Collections;

public class puz1move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float speed = 0.1F;
	void Update() {
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
			Vector3 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
		}
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit();
	}
}
