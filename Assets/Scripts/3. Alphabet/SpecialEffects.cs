using UnityEngine;
using System.Collections;

public class SpecialEffects : MonoBehaviour {

	private static SpecialEffects instance;

	//Prefabs
	public GameObject trailPrefab;
	// Use this for initialization
	void Start () {
		instance = this;
	}

	public static GameObject makeTrail(Vector3 position)
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

	// Update is called once per frame
	void Update () {
	
	}
}
