using UnityEngine;
using System.Collections;

public class Effect : MonoBehaviour {
	private static Effect instance;
	public GameObject trailPrefab;

	void Start () {
		instance = this;
		if (trailPrefab == null)/*checking prefab*/
			Debug.LogError("Missing Trail Prefab!");
	}
	

	
	public static GameObject trailMaker(Vector3 position)
	{
		if (instance == null)
		{
			Debug.LogError("There is no Effects Script in the scene!");
			return null;
		}
		
		GameObject trail = Instantiate(instance.trailPrefab) as GameObject;
		trail.transform.position = position;
		
		return trail;
	}
}
