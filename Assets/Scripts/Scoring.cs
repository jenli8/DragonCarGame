using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour {

	int numCats; 
	GUIText catText; 
	bool gotCat; 


	// Use this for initialization
	void Start () {
		gotCat = false; 
		setText (); 
		catText.text = ""; 
	}
	
	// Update is called once per frame
	void Update () {
		setText (); 
	}

	void OnTriggerEnter(Collider c) {
		gotCat = true;
		numCats++; 
	}

	void setText() {
		catText.text = "Number of Cats Collected: " + numCats; 
		if (gotCat == true) {
			catText.text= "Nubmer of Cats Collected: " + numCats; 
		}
	}
}
