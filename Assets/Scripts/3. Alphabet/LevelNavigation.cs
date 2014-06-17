using UnityEngine;
using System.Collections;

public class LevelNavigation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < Input.touchCount; i++) 
		{
			Touch touch = Input.GetTouch (i);
			
			if (touch.phase == TouchPhase.Began)
			{

				Vector3 position = Camera.main.ScreenToWorldPoint(touch.position);

				//Colliders to navigate to levels
				RaycastHit2D hit=Physics2D.Raycast(position,Vector2.zero);
				if(hit !=null && hit.collider !=null) {
					//Debug.Log("I'm hiting "+hit.collider.name);
					string colliderName=hit.collider.name;
					if(colliderName.Equals("Aa")) 
						Application.LoadLevel("Akuru Liyamu1");

					else if(colliderName.Equals("Ra"))
					{
						print ("ra");
					}
					else if(colliderName.Equals("Ta"))
					{
						print ("ta");
					}
					else if(colliderName.Equals("La"))
					{
						print ("la");
					}
					else if(colliderName.Equals("Ma"))
					{
						print ("ma");
					}

				}
			}
		}
	}
}
