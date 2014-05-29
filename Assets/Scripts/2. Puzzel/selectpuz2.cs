using UnityEngine;
using System.Collections;

public class selectpuz2 : MonoBehaviour {
	Animator anim;
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	void FixedUpdate () 
	{
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began ) 
		{
			if(anim.GetBool("IsSelected")==false){
				anim.SetBool ("IsSelected",true);
			}
			else{
				anim.SetBool ("IsSelected",false);
			}
		}
	}
}
