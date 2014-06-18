using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class DrawTrail : MonoBehaviour {
	
	private Dictionary<int, GameObject> trails = new Dictionary<int, GameObject>();

	//collider counter
	int colliderCount=0;

	//Linkedlist for unique collider names
	LinkedList<string> colliderList=new LinkedList<String>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < Input.touchCount; i++) {
			Touch touch = Input.GetTouch(i);
			
			if (touch.phase == TouchPhase.Began)
			{
				//vibration --> WORKING, but can't control the intensity
				//Handheld.Vibrate();

				// Store this new value
				if (trails.ContainsKey(i) == false)
				{
					Vector3 position = Camera.main.ScreenToWorldPoint(touch.position);
					position.z = 20; // Make sure the trail is visible
					
					GameObject trail = SpecialEffects.MakeTrail(position);
					
					if (trail != null)
					{
						Debug.Log(trail);
						trails.Add(i, trail);
					}
				}
			}
			else if (touch.phase == TouchPhase.Moved)
			{
				// Move the trail
				if (trails.ContainsKey(i))
				{
					GameObject trail = trails[i];
					
					Camera.main.ScreenToWorldPoint(touch.position);
					Vector3 position = Camera.main.ScreenToWorldPoint(touch.position);
					position.z = 20; // Make sure the trail is visible
<<<<<<< HEAD
					
					trail.transform.position = position;
					print("drawing");
=======


					//Colliders that a user touch when tracing
					RaycastHit2D hit=Physics2D.Raycast(position,Vector2.zero);
					if(hit !=null && hit.collider !=null) {
						//Debug.Log("I'm hiting "+hit.collider.name);
						string colliderName=hit.collider.name;
						if(!colliderList.Contains(colliderName)) {
							colliderList.AddLast(colliderName);
						}
						//colliderCount++;
					}

					trail.transform.position = position;

					//vibration --> WORKING, but can't control the intensity
					//Handheld.Vibrate();
					//print("drawing");
>>>>>>> e9e0e35143244ea0cde860daf16f1463db3d34a6
				}
			}
			else if (touch.phase == TouchPhase.Ended)
			{
				//no of colliders hit
				colliderCount=colliderList.Count;
				//print ("Counter="+colliderCount);
				colliderList.Clear();

				if(colliderCount>=40) //tracing is correct
				{ 
					print ("Right");
					SpecialEffects.MakeExplotion();
					//Wait 2s before going back
					System.Threading.Thread.Sleep(4000);
					Application.LoadLevel("Akuru Liyamu");
				}

				else 
				{
					print ("Wrong");
					// Clear known trails
					if (trails.ContainsKey(i))
					{
						GameObject trail = trails[i];
						
						// Let the trail fade out
						//Destroy(trail, trail.GetComponent<TrailRenderer>().time);
						Destroy(trail, 2);
						trails.Remove(i);
						colliderCount=0;
						
					}
				}

				/* Clear known trails
				if (trails.ContainsKey(i))
				{
					GameObject trail = trails[i];
					
					// Let the trail fade out
					//Destroy(trail, trail.GetComponent<TrailRenderer>().time);
					Destroy(trail, 2);
					trails.Remove(i);
					colliderCount=0;

				} */

			}
		} // end of for
	}
}

