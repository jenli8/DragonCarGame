using UnityEngine;
using System.Collections;

public class CountDownTimer : MonoBehaviour {
	
	float timeR = 200;
	GUIStyle style;
	int numCats; 

	// Use this for initialization
	void Start () {
		style = new GUIStyle ();
		style.fontSize = 16;
		style.normal.textColor = Color.white;
		numCats = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timeR -= Time.deltaTime;
	}

	void OnTriggerEnter(Collider c) {
		numCats++; 
		Destroy (c.gameObject); 
	}

	void OnGUI() {
		if (timeR > 0) {
			GUI.Label (new Rect (50, 50, 250, 1000), "Time Remaining:" + timeR + " Score: " + numCats, style);
		} else {
			GUI.Label (new Rect (50, 50, 250, 1000), "Game Over", style);
			//Application.Quit(); 
		}
	}
}