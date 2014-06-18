using UnityEngine;
using System.Collections;

public class shapeEffects : MonoBehaviour {

	private static shapeEffects instance;
	public GameObject trailPrefab;
	// Use this for initialization
	void Start () {
		instance = this;
		if (trailPrefab == null)
			Debug.LogError("Missing Trail Prefab!");
	}
	
	// Update is called once per frame
	
	public static GameObject MakeTrail(Vector3 position)
	{
		if (instance == null)
		{
			Debug.LogError("There is no SpecialEffectsScript in the scene!");
			return null;
		}
		
		GameObject trail = Instantiate(instance.trailPrefab) as GameObject;
		trail.transform.position = position;
		
		return trail;
	}
}
