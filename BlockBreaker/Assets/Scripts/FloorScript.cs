using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {

	public LevelManager myLevelManager;


	void OnTriggerEnter2D (Collider2D trigger) {
		myLevelManager.LevelLoad ("GameOver");

	}










	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
