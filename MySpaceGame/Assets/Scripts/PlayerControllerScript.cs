using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {

	private Rigidbody2D rigid;
	public float thrust = 3f; 
	public float rotationPower = 3f;
	public GameObject laserPrefab;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate (0, 0, -Input.GetAxis ("Horizontal") * rotationPower);
		rigid.AddForce (transform.up * Input.GetAxis ("Vertical") * thrust);
		
	}


	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			Instantiate(laserPrefab);
		}

	
	
	
	}
}
