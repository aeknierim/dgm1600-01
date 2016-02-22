using UnityEngine;
using System.Collections;

public class foreachLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string[] strings = new string[9];

		strings[0] = "Taco";
		strings[1] = "Burrito";
		strings[2] = "Quesadilla";
		strings[3] = "Taquito";
		strings[4] = "Tostada";
		strings[5] = "Flauta";
		strings[6] = "Tamale";
		strings[7] = "Chile Relleno";
		strings[8] = "Sopa";

		foreach(string item in strings)
		{
			print (item);
		}
	}
	
}
