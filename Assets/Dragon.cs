using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class Dragon : MonoBehaviour {

	public static GameObject car;

	// Use this for initialization
	void Start () {
		car = GameObject.Find ("Car");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (car.transform.position.x + 5, car.transform.position.y + 5, car.transform.position.z + 5);
		/*if (car.GetComponent<CarUserControl> ().stopped == true) {
			gameObject.SetActive (true);
		} else {
			gameObject.SetActive (false);
		}*/
	}
		
}
