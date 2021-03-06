﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guessing : MonoBehaviour 
{
	public Text textBox;

	private int max = 100;
	private int min = 1;
	private int guess;

	public int counter;


	// Use this for initialization
	void Start () 
	{
		guess = Random.Range (min, max);


		textBox.text = "Welcome to Number Guesser!"
		+ "\nPick a number in your head. "
		+ "\n\nThe highest number you can pick is " + max + "."
		+ "\nThe lowest number you can pick is " + min + "."
		+ "\n I have " + counter + " chances to guess."
		+ "\n\nIs the number higher or lower than " + guess + "?"
		+ "\nUp arrow for higher, Down arrow for lower, Enter for equal";








		print ("Welcome to Number Guesser");
		print ("Pick a number in your head");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow for higher, Down arrow for lower, Enter for equal");
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (counter == -1) 
		{
			if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow)) 
			{
				print ("You win!");
				textBox.text = "<color=green>You win!</color>";
			}
		}	
		else if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			min = guess; 
			guess = (max + min) / 2;
			counter--; 
			textBox.text = "Is the number higher or lower than " + guess + "?";
			print ("Is the number higher or lower than " + guess + "?");
		} 
		else if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			max = guess; 
			guess = (max + min) / 2;
			counter--; 
			textBox.text = "Is the number higher or lower than " + guess + "?";
			print ("Is the number higher or lower than " + guess + "?");
		} 
		if (Input.GetKeyDown (KeyCode.Return)) 
		{
			textBox.text = "<color=red>I win! Your number is " + guess + "!</color>";
			print ("I win! Your number is " + guess);
		}

		if (counter == 0) 
		{
			counter--;

		}
	
	}
}