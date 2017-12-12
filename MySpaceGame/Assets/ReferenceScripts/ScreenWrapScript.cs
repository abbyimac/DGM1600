using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrapScript : MonoBehaviour {

	
	// Update is called once per frame
	void FixedUpdate () {
		
		Vector3 pos = transform.position;
		if (transform.position.y < -4.5f) 
			pos.y = 4.5f;
		
		if (transform.position.y > 4.5f) 
			pos.y = -4.5f;
		
		if (transform.position.x < -5.5f) 
			pos.x = 5.5f;
	
		if (transform.position.x > 5.5f) 
			pos.x = -5.5f;
	
		transform.position = pos;

}

	}

