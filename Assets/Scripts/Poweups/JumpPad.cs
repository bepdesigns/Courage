using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour 
{
	public float jumpforce = 4;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnCollision(Collider other)
	{
		if (other.tag == "Player") 
		{
			PlayerController pc = other.gameObject.GetComponent<PlayerController> ();
			pc.moveDirection.y = jumpforce * 3;

		}
	}
}
