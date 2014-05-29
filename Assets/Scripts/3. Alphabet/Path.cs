using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Path : MonoBehaviour {

	//public Transform pointerPrefab;
	public GameObject pointerPrefab;
	private LinkedList<Object> path= new LinkedList<Object>();
	private Object pen;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			if(touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled) {
				Vector3 touchPosition=Camera.main.ScreenToWorldPoint(touch.position);
				touchPosition.z=0;
				if(touchPosition.x>=-2.9 && touchPosition.x<=2.6) {
					pen=Instantiate(pointerPrefab,touchPosition,Quaternion.identity);
					path.AddLast(pen);
				}
			}

			else {

				//wait 2s before destroying the path
				System.Threading.Thread.Sleep(1500);

				foreach (Object pen in path) {
					DestroyObject(pen);
				}
			}
			
		}

	}


}
