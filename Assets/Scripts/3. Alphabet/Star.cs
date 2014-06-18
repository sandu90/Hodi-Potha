using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Star : MonoBehaviour {

	public GameObject star;
	// Use this for initialization
	void Start () {
		print("running this");
		//iTween.MoveTo(star,iTween.Hash("position",new Vector3(0, 0, 0),"time", 3.0f, "oncomplete", "setPosAndSpeed", "oncompletetarget", star));
		//iTween.MoveTo(gameObject, iTween.Hash ("position",new Vector3(0, 0, -10)));
		iTween.MoveTo(star, iTween.Hash ("position",new Vector3(0, 0, -10)));
	}
}