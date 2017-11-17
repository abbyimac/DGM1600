using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour {


	public int health;
	public Sprite[] picture;
	private int count = 0;
	private LevelManagerScript levelManager;



	void Start () {
		levelManager = FindObjectOfType<LevelManagerScript> ();
	}

	void OnCollisionEnter2D (Collision2D myCollider) {

		//Take away health
		health--;
		count++;

		// if health is < 0 destroy brick
		if (health <= 0) {
			LevelManagerScript.brickCount--;
			levelManager.CheckBrickCount ();
			Destroy (this.gameObject);
		}

		//change the picture
		GetComponent<SpriteRenderer>().sprite = picture[count];

	}
}
