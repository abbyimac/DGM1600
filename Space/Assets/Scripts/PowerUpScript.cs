using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour {

	public enum Type {fancyLaser, shield, speedBooster};
	public Type powerupType;
	public Sprite[] images;




	// Use this for initialization
	void Start () {

		switch (powerupType) {
		case Type.fancyLaser:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [0];
			break;
		case Type.shield:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [1];
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
	
		Debug.Log ("We hit a powerup!");

		switch (powerupType) {
		case Type.speedBooster: 
			other.GetComponent<PlayerController> ().speed *= 2;
			break;
		
		case Type.shield:

			break;
	
		case Type.fancyLaser:

			break;

		}
			

		Destroy (this.gameObject);
	}



}
