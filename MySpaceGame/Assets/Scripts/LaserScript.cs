using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {

	private Rigidbody2D rigid;
	public float speed = 3f;


	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D>();
		rigid.velocity = transform.up * speed;
		
	}
	

}
