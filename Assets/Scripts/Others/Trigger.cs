using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour 

{
	private Vector3 spawn;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			other.transform.position = spawn;
			//Destroy (other.gameObject);
		}
	}

	// Use this for initialization
	void Start () 
	{
		spawn = new Vector3 (11,1,-90);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
