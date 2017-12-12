using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControllerScript : MonoBehaviour {

	public float spawnTime = 5f;
	private float nextSpawn = 3f;
	public float decay = 0.95f;
	public GameObject meteorPrefab;



	// Update is called once per frame
	void Update () {
		if (nextSpawn > 0)
			nextSpawn = nextSpawn - Time.deltaTime;
		else {
			nextSpawn = nextSpawn + spawnTime;
			spawnTime = spawnTime * decay;
			Instantiate (meteorPrefab);
		}

		
	}
}
