using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour {

	public float speed = 1f;
	private Rigidbody2D rigid;


	// Use this for initialization
	void Start () {

		rigid = GetComponent<Rigidbody2D>();
		rigid.velocity = transform.right * speed;
		rigid.AddTorque (Random.Range (-5f, 5f));
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.CompareTag ("Laser")) {
			Destroy (gameObject);
			Destroy (other.gameObject);
			FindObjectOfType<ScoreboardScript> ().IncrementScore (10);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
