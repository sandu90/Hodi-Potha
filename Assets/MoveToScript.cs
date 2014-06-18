using UnityEngine;
using System.Collections;

public class MoveToScript : MonoBehaviour {
	public string targetLevel="hodi1";
	public AudioClip click;
	
	private RuntimePlatform platform;
	// Use this for initialization
	void Start () {
		platform = Application.platform;
	}
	
	// Update is called once per frame
	void Update () {
		if (platform==RuntimePlatform.Android || platform==RuntimePlatform.WP8Player || platform==RuntimePlatform.IPhonePlayer) {
			if(Input.touchCount > 0){
				if(Input.GetTouch(0).phase == TouchPhase.Began){
					CheckTouch(Input.GetTouch(0).position);
				}
				if(Input.GetTouch(0).phase == TouchPhase.Ended){
					CheckTouchOver(Input.GetTouch(0).position);
				}
			}
		}
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit();
	}
	
	void CheckTouch(Vector2 pos){
		Vector3 wp = Camera.main.ScreenToWorldPoint (pos);
		Vector2 touchPos = new Vector2 (wp.x, wp.y);
		var hit = Physics2D.OverlapPoint (touchPos);
		if(hit && hit.transform.gameObject.name=="1"){
			audio.PlayOneShot(click);
		}
		
	}
	void CheckTouchOver(Vector2 pos){
		Vector3 wp = Camera.main.ScreenToWorldPoint (pos);
		Vector2 touchPos = new Vector2 (wp.x, wp.y);
		var hit = Physics2D.OverlapPoint (touchPos);
		Debug.Log ("hi");
		if(hit && hit.transform.gameObject.name=="1"){
			
			Application.LoadLevel(targetLevel);
		}
		
	}
}
