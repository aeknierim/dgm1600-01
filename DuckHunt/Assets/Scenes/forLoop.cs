using UnityEngine;
using System.Collections;

public class forLoop : MonoBehaviour {

	int numPineapples = 5;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < numPineapples; i++) {
			Debug.Log ("Have another pineapple, this makes: " + i);
		}
	}

}
