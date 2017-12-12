using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour {

	private Rigidbody2D rigid;
	public float speed = 1f;


	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
		rigid.velocity = transform.right * speed;
		rigid.AddTorque (Random.Range(-5f, 5f));
	}
	
	// Update is called once per frame
	void Update () {

	}
}