using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour {

	//public float maxThrust;
	//public float maxTorque;
	//public Rigidbody2D rigid;


	public float speed = 1f;
	private Rigidbody2D rigid;


	// Use this for initialization
	void Start () {

		rigid = GetComponent<Rigidbody2D>();
		rigid.velocity = transform.right * speed;
		rigid.AddTorque (Random.Range (-5f, 5f));
		//Vector2 thrust = new Vector2 (Random.Range (-maxThrust, maxThrust), Random.Range (-maxThrust, maxThrust));
		//float torque = Random.Range (-maxTorque, maxTorque);

		//rigid.AddForce (thrust);
		//rigid.AddTorque (torque);

	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.CompareTag ("Laser")) {
			Destroy (gameObject);
			Destroy (other.gameObject);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
