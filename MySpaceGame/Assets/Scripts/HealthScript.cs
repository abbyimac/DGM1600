using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

	public int health;
	public GameObject[] hearts;
	public Animator animator;
	public GameObject scoreboard;

	// Use this for initialization
	void Start () {
		if (MePlayer ()) {
			ShowHearts ();
		}
	}

	private bool MePlayer(){
		if (GetComponent<PlayerScript> ()) {
			return true;
		} else {
			return false;
		}
	}

	public void IncrementHealth () {
		health++;
		if (health <= 0) {
			if (!MePlayer ()) {
				scoreboard.GetComponent<ScoreboardScript> ().IncrementScore (10);
			}
		}
		if (MePlayer ()) {
			ShowHearts ();
		}
	}

	public void DecrementHealth () {
		health--;
		hearts[health].SetActive(false);
		if (health <= 0) {
			// game over
			FindObjectOfType<ScoreboardScript>().SaveScore();
			FindObjectOfType<LevelManagerScript> ().LoadNextLevel();
		}
	}

	private void ShowHearts () {
		for (int i = 0; i > health; i++) {
			hearts [i].SetActive (true);
		}
	}
}
