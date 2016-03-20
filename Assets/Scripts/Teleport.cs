using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public Transform exit;
	static Transform last; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		if(exit == last ) {
			return; 
		}
		TeleportToExit (other); 
	}

	void OnTriggerExit ( )
	{
		if ( exit == last )
			last = null;
	}
	void TeleportToExit ( Collider other )
	{
		last = transform;
		other.transform.position = exit.transform.position;
	}
}
