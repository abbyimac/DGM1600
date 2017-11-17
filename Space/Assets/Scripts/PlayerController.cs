using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float shipSpeed;
	public float speed;
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public ParticleSystem particles;
	//public float thrusterForce;



	void Start () {
		
	}
	

	void Update () {

		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;

		if (Input.GetKey (KeyCode.UpArrow)) {
			particles.Emit (1);
		}


		if (Input.GetButtonUp ("Fire1")) {
			GameObject shot = Instantiate (projectile, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);

		} 



			//shot.AddForce(shotPos.forward * shotForce);

		}

		//switch (health) {
		//case 1: //do something; break;
		//case 2: //	
		//default:
		//	break;
		}


		
	
	
	
		
