using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {


	public GameObject laserPrefab;
	public Transform shotPos;
	public float shotForce;
	public ParticleSystem particles;
	public float maxSpeed = 5f;
	public float rotSpeed = 180f;
	float shipBoundaryRadius = 0.5f;
	public HealthScript healthScript;

	void Start () {
		
	}

	void Update () {

		//rotate
		Quaternion rot = transform.rotation;
		float z = rot.eulerAngles.z;
		z -= Input.GetAxis ("Horizontal") * rotSpeed * Time.deltaTime;
		rot = Quaternion.Euler (0, 0, z);
		transform.rotation = rot;

		//move

		Vector3 pos = transform.position;
		Vector3 velocity = new Vector3 (0, Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime, 0);

		pos += rot * velocity;
		transform.position = pos;

		//restrict the player to the camera's boundaries
		if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize) {
			pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
		}

		if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize) {
			pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
		}
			
		float screenRatio = (float) Screen.width / (float) Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;

		if (pos.x + shipBoundaryRadius > widthOrtho) {
			pos.x = widthOrtho - shipBoundaryRadius;
		}

		if (pos.x - shipBoundaryRadius < -widthOrtho) {
			pos.x = -widthOrtho + shipBoundaryRadius;
		}

		transform.position = pos;

		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject shot = Instantiate (laserPrefab, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);
		}
			
	}

	void OnCollisionEnter2D (Collision2D collision) {
		FindObjectOfType<HealthScript>().DecrementHealth();
		if (collision.gameObject.CompareTag ("Asteroid")) {
			Destroy (collision.gameObject);
		}
	}
}
