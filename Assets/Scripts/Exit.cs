using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {
	public GUIStyle style;
	int count=0;
	GUISkin skin;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) 
		{
			count=1;

		}
	}

	void OnGUI() {

		if (count == 1) {
			GUI.skin=skin;
			GUI.Box(new Rect(0,0,Screen.width,Screen.height),"");
			GUI.Label(new Rect(Screen.width*1/4,Screen.height*2/6,Screen.width*2/4,Screen.height*1/4), "bj;z",style);
			/*GUI.Label (new Rect (130, 0, 200, 100), "u want to exit?");
		
			if (GUI.Button (new Rect (120, 20, 100, 100), "Yes")) {
				Application.Quit ();
				//print ("exit game");
			}
			if (GUI.Button (new Rect (120, 20, 100, 100), "No")) {
				Application.LoadLevel ("Akuru Liymu");
				//print ("NOOOOO!");
			}*/
			//if(GUI.Button(new Rect(Screen.width/4,Screen.height*3/8,Screen.width/2,Screen.height/8),"Yes",style))
			if(GUI.Button(new Rect(Screen.width/4,Screen.height*4/8,Screen.width/2,Screen.height/8),"Yes",style))
			//if(GUI.Button("Yes",style))
			{
				
				Application.Quit();
				
			}
			//if(GUI.Button(new Rect(Screen.width/4,Screen.height*4/8,Screen.width/2,Screen.height/8),"No",style))
			if(GUI.Button(new Rect(Screen.width/8,Screen.height*4/8,Screen.width/2,Screen.height/8),"No",style))
			//ifGUI.Button("Yes",style))
			{
				count = 0;
			}
		}
	}
}
	