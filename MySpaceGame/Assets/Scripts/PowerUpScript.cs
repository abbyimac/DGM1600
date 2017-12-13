using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour {

	public enum Type {fancyLaser, speedBooster};
	public Type powerupType;
	public Sprite[] images;




	// Use this for initialization
	void Start () {

		switch (powerupType) {
		case Type.fancyLaser:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [0];
			break;
		case Type.speedBooster:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [2];
			break;
		}

	}

	// Update is called once per frame
	void Update () {

	}



	void OnTriggerEnter2D(Collider2D other){

		if (!other.gameObject.CompareTag("Laser") && !other.gameObject.CompareTag("Asteroid")) {

			switch (powerupType) {
			case Type.speedBooster: 
				FindObjectOfType<PlayerScript> ().IncreaseSpeed (0.4f);
				break;

			case Type.fancyLaser:
				FindObjectOfType<PlayerScript> ().IncrementGuns ();
				break;

			}

			Destroy (this.gameObject);
		}
	}
}
