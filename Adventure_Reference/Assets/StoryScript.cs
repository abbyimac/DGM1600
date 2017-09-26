using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour 
{

	public Text textObject;
	public enum States {start, forest, cave, shore_0 };
	public States myCurrentState;


	// Use this for initialization
	void Start () 
		{
			myCurrentState = States.start;

		}
	
	// Update is called once per frame
	void Update () 
		{
		if (myCurrentState == States.start) {
			State_start (); 
		} else if (myCurrentState == States.forest) {
			State_forest ();
		} else if (myCurrentState == States.cave) {
			State_cave ();
			}
		}

	// State: start
	void State_start () 
		{
		textObject.text = "You are on a small desert island. " +
		"\nThere is a Forest with trees." +
		"\nThere is a Cave." +
		"\n\nPress F to go to Forest. Press C to go to Cave.";

		if (Input.GetKeyDown (KeyCode.F)) {
			myCurrentState = States.forest;
			}

		else if (Input.GetKeyDown (KeyCode.C)) {
			myCurrentState = States.cave;
			}


		}
	// State: Forest
	void State_forest ()
		{
		textObject.text = "Forest State";
		}

	// State: Cave
	void State_cave() 
		{
		textObject.text = "Cave State";
		}
}
