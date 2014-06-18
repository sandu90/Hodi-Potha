﻿using UnityEngine;
using System.Collections;

public class BackNavigation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		for (int i=0; i<Input.touchCount; i++) {
			if(this.guiTexture.HitTest(Input.GetTouch(i).position)) {
				if(Input.GetTouch(i).phase == TouchPhase.Began) {
					Application.LoadLevel ("Akuru Liyamu");
				}
			}
		}
	}
}
