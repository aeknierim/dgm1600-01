using UnityEngine;
using System.Collections;

public class scopeAccess : MonoBehaviour {

	public int alpha = 10;

	private int beta = 2;
	private int gamma = 8;

	public anotherScript myOtherScript;

	// Use this for initialization
	void Start () {
		alpha = 40;

		myOtherScript = new anotherScript ();
		myOtherScript.FruitMachine (alpha, myOtherScript.apples);
	
	}

	void Update (){
		Debug.Log ("this is my number" + alpha);
	}

}
