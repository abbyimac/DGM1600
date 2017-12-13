using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreboardScript : MonoBehaviour {

	private int highScore;
	private int score;
	public Text display;
	public Text highScoreDisplay;
	public Text prevScoreDisplay;


	void Start () {
		score = 0;
		if (display != null) {
			display.text = score.ToString ();
		}
		if (highScoreDisplay != null) {
			highScoreDisplay.text = GetHighScore().ToString ();
		}
		if (prevScoreDisplay != null) {
			prevScoreDisplay.text = GetPrevScore().ToString ();
		}
	}
	
	public void IncrementScore (int value) {
		score += value;
		display.text = score.ToString ();
	}

	public void SaveScore (){
		PlayerPrefs.SetInt ("PrevScore", score);
		int highScore = GetHighScore ();
		if (score > highScore) {
			PlayerPrefs.SetInt ("HighScore", score);
		}
	}

	public int GetPrevScore(){
		return PlayerPrefs.GetInt ("PrevScore");
	}

	public int GetHighScore(){
		return PlayerPrefs.GetInt ("HighScore");
	}

	public void OnDisable(){
		SaveScore ();
	}

	void Update () {
		
	}
}
