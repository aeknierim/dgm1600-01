using UnityEngine;
using System.Collections;

public class whileLoop : MonoBehaviour {

	int candybarsInMyPurse = 5;

	// Use this for initialization
	void Start () {
		while (candybarsInMyPurse > 0) {
			Debug.Log ("I ate a candybar!");
			candybarsInMyPurse--;
		}
	}
	
}
