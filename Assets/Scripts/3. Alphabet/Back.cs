﻿using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Escape)) 
		{

			Application.LoadLevel("Akuru Liyamu");

		}
	}
}
