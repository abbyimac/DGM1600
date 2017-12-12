﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControllerScript : MonoBehaviour {

	public float spawnTime = 4f;
	private float nextSpawn = 3f;
	public float decay = 0.8f;
	public GameObject meteorPrefab;
	public GameObject playerPrefab;
	private GameObject explosionEffect;

	void Start () {
		Instantiate (playerPrefab, Vector3.zero, Quaternion.Euler (0, 0, 0));
	}

	// Update is called once per frame
	void Update () {
		if (nextSpawn > 0)
			nextSpawn = nextSpawn - Time.deltaTime;
		else {
			nextSpawn += spawnTime;
			spawnTime = spawnTime * decay;
			Quaternion angle = Quaternion.Euler (0, 0, Random.Range (0f, 360f));
			GameObject meteor = Instantiate (meteorPrefab, new Vector3 (0, 5, 0), angle) as GameObject;
			meteor.transform.RotateAround (Vector3.zero, Vector3.forward, Random.Range (0f, 360f));
		}
	}

	public void CreateExplosion(){
		
	}
}
