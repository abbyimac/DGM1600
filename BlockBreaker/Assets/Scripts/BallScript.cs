using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public GameObject paddle;
	private Vector3 paddleToBallVector; //Distance from ball to paddle
	public bool playing = false;
	private Rigidbody2D rigid;


	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
		rigid = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (!playing) {
			this.transform.position = paddle.transform.position + paddleToBallVector;
		
		//if push start button
			if (Input.GetMouseButtonDown (0)) {
				//ball goes flying
				rigid.velocity = new Vector2 (0,18);
				//playing = true
				playing = true;
			}
		}


			
	}
}
