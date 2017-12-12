using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour {


	public static int meteorCount;




	void Start () {
		meteorCount = FindObjectsOfType<MeteorScript> ().Length;
		print (meteorCount);
	}

	public void LevelLoad (string name) {
		SceneManager.LoadScene (name);
	
	
	}





	public void ExitGame () {

		print ("Tried to Exit.");
		Application.Quit ();
	
	}

	public void LoadNextLevel () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);



	}
		
	public void CheckBrickCount () {
		if (meteorCount <= 0) {
			LoadNextLevel ();
		}
	}

}
