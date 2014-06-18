using UnityEngine;
using System.Collections;

public class SpecialEffects : MonoBehaviour {
	private static SpecialEffects instance;
	public GameObject trailPrefab;
	public ParticleSystem explotionPrefab;

	// Use this for initialization
	void Start () {
		instance = this;
		if (trailPrefab == null)
			Debug.LogError("Missing Trail Prefab!");
		if (explotionPrefab == null)
			Debug.LogError("Missing Explotion Prefab!");
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

	public static void MakeExplotion()
	{
		print ("calling oky");

		ParticleSystem effect = Instantiate (instance.explotionPrefab) as ParticleSystem;

		Vector3 pos;
		pos.x = 0;
		pos.y = 0;
		pos.z = 0;
		effect.transform.position=pos;
		Destroy (effect.gameObject, effect.duration);
	}
}

