using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {

	private Rigidbody2D rigid;
	public float speed = 3f;
	public float lifetime;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D>();
		rigid.velocity = transform.up * speed;
	}

	void Update () {
		lifetime -= Time.deltaTime;
		if (lifetime <= 0) {
			Destroy (this.gameObject);
		}

	}

	//void OnTriggerEnter2D(Collider2D other)
	//{
		//Destroy (gameObject);
	//}
}