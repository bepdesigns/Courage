using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour {

	public bool inTrigger;

	Animator anim;
	public AudioClip pickup;
	private AudioSource audio;


	void Start()
	{
		anim = GameObject.FindWithTag("Player").GetComponent<Animator>();
		audio = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other)
	{
		inTrigger = true;
	}

	void OnTriggerExit(Collider other)
	{
		inTrigger = false;
	}

	void Update()
	{
		if (inTrigger)
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				anim.SetTrigger("pickup");
				DoorScript.doorKey = true;
				audio.PlayOneShot(pickup, 0.7F);
				Destroy(this.gameObject);
			}
		}
	}

	void OnGUI()
	{
		if (inTrigger)
		{
			GUI.Box(new Rect(400, 200, 200, 25), "Press E to take key");
		}
	}
}
