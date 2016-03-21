using UnityEngine;
using System.Collections;

public class CountDownTimer : MonoBehaviour {
	
	float timeR = 200;
	GUIStyle style;
	
	// Use this for initialization
	void Start () {
		style = new GUIStyle ();
		style.fontSize = 16;
		style.normal.textColor = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		timeR -= Time.deltaTime;
	}
	
	void onGUI() {
		if (timeR > 0) {
			GUI.Label (new Rect (50, 50, 250, 100), "Time Remaining:" + timeR, style);
		} else {
			GUI.Label (new Rect (50, 50, 250, 100), "Game Over", style);
			//Application.Quit(); 
		}
	}
}