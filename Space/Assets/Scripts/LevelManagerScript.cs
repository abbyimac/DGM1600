﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour {



	void Start () {

	}

	public void LevelLoad (string name) {
		SceneManager.LoadScene (name);
	
	
	}




	//NOT HAVE THIS FUNCTION WITH A MOBILE BUILD
	public void ExitGame () {

		print ("Tried to Exit.");
		Application.Quit ();
	
	}

	public void LoadNextLevel () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);



	}
		

		


}