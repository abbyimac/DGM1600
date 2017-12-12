using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour {

	public Transform objectToFollow;
	public float zOffset;

	
	// Update is called once per frame
	void Update () {
		Vector3 myPos = objectToFollow.position;
		myPos.z = zOffset;
		gameObject.transform.position = myPos;
		
	}
}
