using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagerScript : MonoBehaviour //{

	// Use this for initialization
	//void Start () {
	//	DontDestroyOnLoad (this); 

	//}

{
	private static MusicManagerScript instance = null;
	public static MusicManagerScript Instance {
		get { return instance; }
	}


	void Awake() {
		if (instance != null && instance != this) 
		{
			Destroy(this.gameObject);
			return;
		} 
		else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);



}
}

