using UnityEngine;
using System.Collections;
using Random=System.Random;

public class NumberWizardScript : MonoBehaviour {
	
	int min, max, guess;
	Random rnd = new Random();
	
	// Use this for initialization
	void Start () {
		StartGame();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			print("Up key was pressed");
			min = guess;
			nextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)){
			print("Down key was pressed");
			max = guess;
			nextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)){
			print("!! Your number is " + guess + " !! ");
			StartGame();
		}
	}
	
	void StartGame(){
		min = 1;
		max = 1000;
		guess = rnd.Next(1, 1001);
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equals");
		
		max += 1;
	}
	
	void nextGuess(){
		guess = rnd.Next(min, max);
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equals");
	}
	
}
