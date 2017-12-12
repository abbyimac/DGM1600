using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour {

	private Rigidbody2D rigid;
	private GameObject player;
	private LevelManagerScript levelManager;
	//private int count = 0;
	public Sprite[] picture;
	public int health;
	public float startingSpin;

	//public float speed = 1f;


	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddTorque (Random.Range (-startingSpin, startingSpin), ForceMode2D.Impulse);
	//	rigid = GetComponent<Rigidbody2D> ();
	//	rigid.velocity = transform.right * speed;
	//	rigid.AddTorque (Random.Range(-5f, 5f));


	}
	
	// Update is called once per frame
	void Update () {
		//GetComponent<Rigidbody2D> ().AddTorque (Random.Range (-startingSpin, startingSpin), ForceMode2D.Impulse);
	}
}