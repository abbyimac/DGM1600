using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MonkeyStoryScript : MonoBehaviour 
{

	public Text textObject;
	public enum States {start, zookeeper, bird, friend, lose_dave, lose_peanut, 
						tigers, lions, lose_lions, snakes, lose_snakes, rhinos, lose_rhinos, zebras, bears, stagetwo, premutiny, lose_mutiny, free_monkeys, win};
	public States myCurrentState;

	public bool peanut = false;
	public bool keys = false;
	public bool dave = false;
	public bool zookeeper = false;
	public bool tigers = false;
	public bool zebras = false;
	public bool bears = false;
	public bool rhinos = false;
	public bool snakes = false;
	public bool lions = false;

	// Use this for initialization
	void Start () {

		myCurrentState = States.start;

	}
	
	// Update is called once per frame
	void Update () {

		if (myCurrentState == States.start) {
			State_start ();
		} else if (myCurrentState == States.zookeeper) {
			State_zookeeper ();
		} else if (myCurrentState == States.bird) {
			State_bird ();
		} else if (myCurrentState == States.friend) {
			State_friend ();
		} else if (myCurrentState == States.lose_dave) {
			State_lose_dave ();
		} else if (myCurrentState == States.lose_peanut) {
			State_lose_peanut ();
		} else if (myCurrentState == States.bears) {
			State_bears ();
		} else if (myCurrentState == States.zebras) {
			State_zebras ();
		} else if (myCurrentState == States.tigers) {
			State_tigers ();
		} else if (myCurrentState == States.lions) {
			State_lions ();
		} else if (myCurrentState == States.lose_lions) {
			State_lose_lions ();
		} else if (myCurrentState == States.snakes) {
			State_snakes ();
		} else if (myCurrentState == States.lose_snakes) {
			State_lose_snakes ();
		} else if (myCurrentState == States.rhinos) {
			State_rhinos ();
		} else if (myCurrentState == States.lose_rhinos) {
			State_lose_rhinos ();
		} else if (myCurrentState == States.lose_mutiny) {
			State_lose_mutiny ();
		} else if (myCurrentState == States.stagetwo) {
			State_stagetwo ();
		} else if (myCurrentState == States.win) {
			State_win ();
		}


	}


	// Monkey cage, options
	void State_start ()
	{

		textObject.text = "You are a monkey at the zoo. " +
		"\nThe zoo stinks. The zookeeper is mean, the bananas are always brown, and all of the other monkeys make fun of you." +
		"\nYour only friends are a lazy monkey named Dave and a crafty bird named Pablo." +
		"\n\nAs all the people leave the zoo, the zookeeper comes to give you your nightly peanut snack." +
		"\nPress Z to go to the zookeeper, press D to talk to Dave, or press P to talk to Pablo.";

		if (Input.GetKeyDown (KeyCode.Z)) {
			myCurrentState = States.zookeeper;
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			myCurrentState = States.friend;
		}

		if (Input.GetKeyDown (KeyCode.P)) {
			myCurrentState = States.bird;
		}

	}



	// Monkey cage, looking at zookeeper
	void State_zookeeper ()
	{
		zookeeper = true;
		if (peanut == false) {
			textObject.text = "The zookeeper fills all the other food dishes with peanuts, except for yours." +
			"\nThen he laughs. How rude." +
			"\n\nPress D to go talk to Dave, press P to go talk to Pablo.";

			if (Input.GetKeyDown (KeyCode.D)) {
				myCurrentState = States.friend;
			} 
			if (Input.GetKeyDown (KeyCode.P)) {
				myCurrentState = States.bird;
			}
		

		}
	}



	// Monkey cage, talking to Pablo
	void State_bird ()
	{
		if (peanut == false && keys == false) {
			textObject.text = "You tell Pablo about how you want to escape." +
			"\nHe can get the keys from the zookeeper, but only if you'll give him a peanut." +
			"\n\nPress D to talk to Dave, press Z to go to the zookeeper.";

			if (Input.GetKeyDown (KeyCode.D)) {
				myCurrentState = States.friend; 
			}
			if (Input.GetKeyDown (KeyCode.Z)) {
				myCurrentState = States.zookeeper;
			}
		}
		if (peanut == true && dave == true && keys == false) {
			textObject.text = "You made a deal with Pablo! You give Pablo a peanut and he gets the keys from the zookeeper!" +
			"\nYou're free!" +
			"\n\nPress L to leave the monkey cage!";

		

			if (Input.GetKeyDown (KeyCode.L)) {
				keys = true;
				peanut = false;
				myCurrentState = States.stagetwo;
			}
	
		}

	}



	// Monkey cage, talking to Dave
	void State_friend ()
	{
		if (zookeeper == false) {
			textObject.text = "Dave looks hungry. You wonder when the zookeeper will feed you." +
			"\n\nPress P to talk to Pablo, press Z to go to the zookeeper.";
			if (Input.GetKeyDown (KeyCode.P)) {
				myCurrentState = States.bird;
			}
			if (Input.GetKeyDown (KeyCode.Z)) {
				myCurrentState = States.zookeeper;
			}
		}



		if (zookeeper == true && peanut == false) {
			textObject.text = "Dave has eaten all of his peanuts already, except one." +
			"\nHe says you can have it if you let him escape with you." +
			"\n\nLet Dave come along? Press Y for yes, press N for no and take the peanut anyway.";
		

			if (Input.GetKeyDown (KeyCode.N)) {
				peanut = true;
				myCurrentState = States.lose_dave;

			} else if (Input.GetKeyDown (KeyCode.Y)) {
				dave = true;
				peanut = true;
				textObject.text = "Now you have a peanut, and Dave is excited!" +
				"\nBefore you leave the zoo, he would love to see the rhinos." +
				"\n\nPress E to eat the peanut, press P to talk to Pablo.";
			}

		}
			if (Input.GetKeyDown (KeyCode.P)) {
				myCurrentState = States.bird;
			}
			if (dave == true & Input.GetKeyDown (KeyCode.E)) {
				myCurrentState = States.lose_peanut;
			}


	}


	void State_stagetwo ()
	{
		textObject.text = "You're out! But because you're a nice monkey, you can't bear to leave without helping the other animals!" +
		"\nSpeaking of bears, their enclosure is right here! You could open their cage right now! Or the rhinos are right next to them." +
			"\n\nPress B to open the bears' cage or press R to open the rhinos' cage.";

		if (Input.GetKeyDown (KeyCode.B)) {
			myCurrentState = States.bears;
		}
		if (Input.GetKeyDown (KeyCode.R)) {
				myCurrentState = States.rhinos;
		}


		if (bears == true) {
			textObject.text = "You don't have a lot of time before the zookeeper catches you. " +
			"\nYou have time to free the lions or the zebras." +
			"\n\nPress L to free the lions, press Z to free the zebras.";
		
			if (Input.GetKeyDown (KeyCode.L)) {
				myCurrentState = States.lions; 
			}
			if (Input.GetKeyDown (KeyCode.Z)) {
				myCurrentState = States.zebras;
			}
		}

		if (zebras == true) {
			textObject.text = "Now you can bring along either the tigers or the snakes." +
				"\n\nPress T to free the tigers, press S to free the snakes.";
			if (Input.GetKeyDown (KeyCode.T)) {
				myCurrentState = States.tigers;
			}
			if (Input.GetKeyDown (KeyCode.S)) {
				myCurrentState = States.snakes;
			}
		}

		if (tigers == true) {
			textObject.text = "Oh no! You and Dave are the only monkeys, and the bigger animals don't like taking orders from you anymore." +
				"\nThey're staging a mutiny!" +
				"\nThe only way to stop them from overthrowing you is to free the other monkeys, even though they're mean to you." +
				"\nWould you like to free the other monkeys? " +
				"\n\nYes or no?";
			if (Input.GetKeyDown (KeyCode.Y)) {
				myCurrentState = States.win;
			}
			if (Input.GetKeyDown (KeyCode.N)) {
				myCurrentState = States.lose_mutiny;
			}
		}
	}
















































	void State_bears ()
	{
		bears = false;
		if (bears == false) {
			textObject.text = "Congratulations, you freed the bears! They're so happy it's almost unbearable." +
				"\n\nPress the spacebar to continue.";
			if (Input.GetKeyDown (KeyCode.Space)) {
				bears = true;
			}
		}

	
		if (bears == true) {
			myCurrentState = States.stagetwo;
		}
	}

	void State_zebras ()
	{
		if (zebras == false) {
			textObject.text = "You freed the zebras! Good job!" +
			"\n\nPress the spacebar to continue.";
			if (Input.GetKeyDown (KeyCode.Space)) {
				zebras = true;
			}
		}
		if (zebras == true) {
			myCurrentState = States.stagetwo;
		}
	}

	void State_rhinos ()
	{
		if (rhinos == false) {
			textObject.text = "You freed the rhinos! But..." +
			"\n\nPress the spacebar to continue.";
			if (Input.GetKeyDown (KeyCode.Space)) {
				rhinos = true;
			}
		}

		if (rhinos == true) {
			myCurrentState = States.lose_rhinos;
		}


	}

	void State_snakes ()
	{
		if (snakes == false) {
			textObject.text = "You freed the snakes! But..." +
				"\n\nPress the spacebar to continue.";
			if (Input.GetKeyDown (KeyCode.Space)) {
				snakes = true;
			}
		}

		if (snakes == true) {
			myCurrentState = States.lose_snakes;
		}


	}

	void State_lions ()
	{
		if (lions == false) {
			textObject.text = "You freed the lions! But..." +
				"\n\nPress the spacebar to continue.";
			if (Input.GetKeyDown (KeyCode.Space)) {
				lions = true;
			}
		}

		if (lions == true) {
			myCurrentState = States.lose_lions;
		}
	}

	void State_tigers ()
	{
		if (tigers == false) {
			textObject.text = "Yay! You freed the tigers!" +
			"\n\nPress the spacebar to continue.";
		
			if (Input.GetKeyDown (KeyCode.Space)) {
				tigers = true;
			}
		}
		if (tigers == true) {
			myCurrentState = States.stagetwo;
		}
	}







	void State_lose_dave ()
	{
		textObject.text = "Dave gets upset. He may look fat and lazy, but he's bigger than you. He takes the peanut back and eats it." +
			"\nNow you'll never get out!" +
			"\n\nYou lose!";
	}

	void State_lose_peanut ()
	{
		textObject.text = "Now how will you trade Pablo for the keys?!" +
		"\n\nYou lose!";
	}








	void State_lose_rhinos ()
	{
		textObject.text = "Dave made a rather loud fat joke about the rhinos. They're sensitive, you know." +
			"\n\nThey trample you and you have to go back to the zoo infirmary." +
			"\nYou lose!";
	}

	void State_lose_snakes ()
	{
		textObject.text = "You silly monkey! Snakes are poisonous!" +
			"\nThe snakes bite you, and you have to go back to the zoo infirmary." +
			"\n\nYou lose!";
	}

	void State_lose_lions ()
	{
		textObject.text = "The lions like the zoo, they don't want to come along. So they eat you." +
			"\n\nYou lose!";
	}

	void State_lose_mutiny ()
	{
		textObject.text = "The other animals make such a ruckus with their revolution that the zookeeper catches you and puts you all back in your cages." +
		"\n\nYou lose!";
	}
		


	void State_win ()
	{
		textObject.text = "You freed the other monkeys, and now they all love you! Congratulations! You successfully escaped the zoo!" +
			"\n\nYou won!";
	}



}
