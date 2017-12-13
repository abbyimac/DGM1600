using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {


	public GameObject laserPrefab;
	public Transform shotPos;
	public Transform shotPos2;
	public Transform shotPos3;
	public float shotForce;
	public ParticleSystem particles;
	public float maxSpeed;
	public float rotSpeed = 180f;
	float shipBoundaryRadius = 0.5f;
	public HealthScript healthScript;
	private int guns;
	public int asteroidsDestroyed;


	void Start () {
		asteroidsDestroyed = 0;
		guns = 1;
		maxSpeed = 5f;
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

		if (velocity.y > 1) {
			particles.Emit (1);
		}

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
			if (guns > 1) {
				GameObject shot2 = Instantiate (laserPrefab, shotPos2.position, shotPos2.rotation) as GameObject;
				shot2.GetComponent<Rigidbody2D> ().AddForce (shotPos2.up * shotForce);
			} 
			if (guns > 2) {
				GameObject shot3 = Instantiate (laserPrefab, shotPos3.position, shotPos3.rotation) as GameObject;
				shot3.GetComponent<Rigidbody2D> ().AddForce (shotPos3.up * shotForce);
			}
		}
			
	}

	void OnCollisionEnter2D (Collision2D collision) {
		FindObjectOfType<HealthScript>().DecrementHealth();
		if (collision.gameObject.CompareTag ("Asteroid")) {
			Destroy (collision.gameObject);
		}
	}

	public void IncrementAsteroidsDestroyed() {
		asteroidsDestroyed++;
		if (asteroidsDestroyed % 3 == 0) {
			FindObjectOfType<SpawnControllerScript>().SpawnRandomPowerUp ();
		}
	}

	public void IncrementGuns () {
		guns++;
	}

	public void IncreaseSpeed (float value) {
		maxSpeed += value;
	}
}
