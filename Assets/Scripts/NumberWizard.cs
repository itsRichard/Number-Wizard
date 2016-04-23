using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max = 1000;
	int min = 1;
	int guess = 500;
	
	void Start () {
		StartGame ();
	}
	
	void StartGame () {
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min); 
		
		max = max + 1;
		
		print ("Is the number higher or lower than " + guess +"?");
		print ("Up arrow = higher.  Down arrow = lower.  Return = equals");
	}
	
	void NextGuess () 
	{
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
		print ("Up arrow = higher.  Down arrow = lower.  Return = equals");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
				min = guess;
				NextGuess ();
			} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
				max = guess;
				NextGuess ();
			} else if (Input.GetKeyDown(KeyCode.Return)) {
				print("I Won!"); 
			}
	}
}
