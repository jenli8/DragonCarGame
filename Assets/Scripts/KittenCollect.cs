using UnityEngine;
using System.Collections;

public class KittenCollect : MonoBehaviour {

	//public GameObject Cat; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider c){
		Destroy (c.gameObject); 
	}
}
