using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	public static bool doorKey;
	public bool open;
	public bool close;
	public bool inTrigger;

	//public Animation anim;

	void Start()
	{
		//anim = GetComponent<Animation>();
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
			if (close)
			{
				if (doorKey)
				{
					if (Input.GetKeyDown(KeyCode.E))
					{
						open = true;
						close = false;
					}
				}
			}
			else
			{
				if (Input.GetKeyDown(KeyCode.E))
				{
					close = true;
					open = false;
				}
			}
		}

		if (open)
		{
			//anim.Play();
			gameObject.GetComponent<Animation>().Play ("GraveYardGate");
			gameObject.GetComponent<Animation>().Play ("GraveYardGateRight");
			//var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 200);
			//transform.rotation = newRot;
		}
		else
		{
			//gameObject.GetComponent<Animation>().Play ("GraveYardGate");
			//gameObject.GetComponent<Animation>().Play ("GraveYardGateRight");
			//var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 200);
			//transform.rotation = newRot;
		}
	}

	void OnGUI()
	{
		if (inTrigger)
		{
			if (open)
			{
				GUI.Box(new Rect(400, 200, 200, 25), "Press E to close");
			}
			else
			{
				if (doorKey)
				{
					GUI.Box(new Rect(400, 200, 200, 25), "Press E to open");
				}
				else
				{
					GUI.Box(new Rect(400, 200, 200, 25), "Need a key!");
				}
			}
		}
	}
}
