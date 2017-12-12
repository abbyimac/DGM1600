using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {

	private Rigidbody2D rigid;
	public float thrust = 3f; 
	public float rotationPower = 3f;
	public GameObject laserPrefab;
	public Transform shotPos;
	public float shotForce;



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
			if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject shot = Instantiate (laserPrefab, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);
			}
		}
	
	
	
}
