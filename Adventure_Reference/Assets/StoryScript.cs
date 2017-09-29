using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour 
{

	public Text textObject;
	public enum States {start, forest, forest_r, cave, shore_0, shore_w, shore_r, shore_fixed};
	public States myCurrentState;

	public bool lockpick = false;
	public bool rope = false;
	public bool wood = false;

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
		} 
		else if (myCurrentState == States.forest) {
			State_forest ();
		}
		else if (myCurrentState == States.cave) {
			State_cave ();
		}
		else if (myCurrentState == States.shore_0) {
			State_shore ();
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
		if (rope == true) {
			textObject.text = "You are in a forest with palm trees." +
			"\nThe palm trees have long wispy palm fronds, good for making rope." +
			"\n\nPress S to go back to Start. Press C to go to cave."; 
		}
		else {
		textObject.text = "You are in a forest with palm trees." +
		"\nThe palm trees have long wispy palm fronds, good for making rope." +
		"\n\nPress R to make Rope." +
		"\n\nPress S to go back to Start. Press C to go to cave.";
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			rope = true;
		}
		else if (Input.GetKeyDown (KeyCode.S)) {
			myCurrentState = States.start;
		}
		else if (Input.GetKeyDown (KeyCode.C)) {
			myCurrentState = States.cave;
		}
	}



	// State: Cave
	void State_cave()
	{	
		if (wood == true) {
			textObject.text = "You are in a cave." +
			"\nThe Shoreline is nearby." +
			"\nThe Cave is damp and drippy." +
			"\n\nPress F to go to Forest. Press S to go to Shore.";
		} 
		else {		
			textObject.text = "You are in a cave." +
			"\nThe Shoreline is nearby." +
			"\nThe Cave is damp and drippy." +
			"\n\nPress W to take Wood." +
			"\n\nPress F to go to Forest. Press S to go to Shore.";
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			wood = true;
		}
		else if (Input.GetKeyDown (KeyCode.F)) {
			myCurrentState = States.forest;
		}
		else if (Input.GetKeyDown (KeyCode.S)) {
			myCurrentState = States.shore_0;
		}
	}

	void State_shore ()
	{
		if (rope == true & wood == true) {
			textObject.text = "You fixed the rigging and the hole.";
		} 
		else if (rope == true) {
			textObject.text = "There is an old sailboat here." +
			"\nYou used Rope to fix the rigging." +
			"\n\nPress D to Depart onboard the sailboat. Press C to go to Cave. Press S to go to Start.";
		} 
		else if (wood == true) {
			textObject.text = "There is an old sailboat here." +
			"\nYou used Wood to fix the hole." +
			"\n\nPress D to Depart onboard the sailboat. Press F to go to Forest. Press S to go to Start.";
		} 
		else if (wood == false & rope == false) {
			textObject.text = "There is an old sailboat here." +
			"\n\nPress D to get on the boat and Depart.";
		}
	}
}