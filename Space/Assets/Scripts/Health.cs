using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int health;
	public GameObject explosionEffect;
	public GameObject[] hearts;

	private void Start(){
		ShowHearts ();

	}
		
	public void IncrementHealth (int value){
		health += value;
		if (health <= 0) {
			Destroy (gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
		}
		ShowHearts ();
	}

	private void ShowHearts(){
		//Turn all hearts off
		for (int i = 0; i < hearts.Length; i++) {
			hearts [i].SetActive (false);
		}
		//Turn hearts on by health
		for (int i = 0; i > health; i++) {
			hearts [i].SetActive (true);
		}
	}





}
