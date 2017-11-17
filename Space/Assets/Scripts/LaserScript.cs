using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {


	public float lifetime;
	public int speed;


	
	// Update is called once per frame
	void Update () {
		lifetime -= Time.deltaTime;
		if (lifetime <= 0) {
			Destroy (this.gameObject);
		}


		//transform.Translate (Vector3.up * speed * Time.deltaTime);
	}
}
