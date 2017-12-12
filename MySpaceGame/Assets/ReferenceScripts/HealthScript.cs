using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

	public int health;
	public GameObject explosionEffect;
	public GameObject[] hearts;
	public Animator animator;
	public GameObject scoreboard;
	public GameObject healthContainer;
	public ScoreboardScript scoreScript;
	public HealthScript healthScript;

	// Use this for initialization
	void Start () {
		if (MePlayer ()) {
			ShowHearts ();
			scoreboard = FindObjectOfType<ScoreboardScript> ().gameObject;
			healthContainer = FindObjectOfType<HealthScript> ().gameObject;
			print (scoreboard);
		}
	}

	private bool MePlayer(){
		if (GetComponent<PlayerMovementScript> ()) {
			return true;
		} else {
			return false;
		}
	}

	public void IncrementHealth (int value) {
		health += value;
		if (health <= 0) {
			Destroy (gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
			if (!MePlayer ()) {
				IncrementScore ();
				//gameObject.GetComponent<PlayerMovementScript> ().levelManager.GetComponent<LevelManagerScript>;
			}
		}
		if (MePlayer ()) {
			ShowHearts ();
		}
	}

	private void ShowHearts () {
	//Turn all hearts off
		for (int i = 0; i < hearts.Length; i++) {
			hearts [i].SetActive (false);
		}
	//Turn hearts on by health
		for (int i = 0; i > health; i++) {
			hearts [i].SetActive (true);
		}
	}

	public void IncrementScore(){
		scoreboard.GetComponent<ScoreboardScript> ().IncrementScoreboard (10);
	}


}
