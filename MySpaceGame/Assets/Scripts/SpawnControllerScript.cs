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
			Quaternion angle = Quaternion.Euler (0, 0, Random.Range (0f, 360f));
			GameObject meteor = Instantiate (meteorPrefab, new Vector3 (0, 20, 0), angle) as GameObject;
			meteor.transform.RotateAround (Vector3.zero, Vector3.forward, Random.Range (0f, 360f));

		}


	}
}
