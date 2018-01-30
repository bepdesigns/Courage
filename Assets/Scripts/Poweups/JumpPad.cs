using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour 
{
	public float power;
	CharacterMotorC cm;

	// Use this for initialization
	void Awake () 
	{
		cm = GameObject.Find ("Player").GetComponent<CharacterMotorC> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	 void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			//PlayerController pc = other.gameObject.GetComponent<PlayerController> ();
			cm.movement.velocity.y = 0;
			cm.movement.velocity = cm.movement.velocity + (transform.up * power);

		}
	}
}
