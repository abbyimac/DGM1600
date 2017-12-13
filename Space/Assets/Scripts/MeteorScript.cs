using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour {

	public float startingSpin;
	public int health;
	public Sprite[] picture;
//	private int count = 0;
	private LevelManagerScript levelManager;
	private GameObject player;
	private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddTorque (Random.Range (-startingSpin, startingSpin), ForceMode2D.Impulse);
	}



	//void OnCollisionEnter2D (Collision2D myCollider) {

		//Take away health
//			health--;
//			count++;

			// if health is < 0 destroy brick
			//if (health <= 0) {
				//LevelManagerScript.brickCount--;
				//levelManager.CheckBrickCount ();
			//	Destroy (this.gameObject);
			//}

			//change the picture
			//GetComponent<SpriteRenderer>().sprite = picture[count];

//		}


	//cause damage to player when it collides with meteor?
	void OnCollisionEnter2D (Collision2D coll) 
	{
		//coll.GameObject.GetComponent<Health> ().IncrementHealth (-1);
	}



	
	

}
