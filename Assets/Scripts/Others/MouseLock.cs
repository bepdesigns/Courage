using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour {


	CursorLockMode wantedMode;



	// Apply requested cursor state



	// Use this for initialization
	void Start () 
	{
		Cursor.visible = (CursorLockMode.Locked != wantedMode);
	}
	
	// Update is called once per frame
	void Update () {


		SetCursorState ();


	}

	void SetCursorState()
	{
		Cursor.lockState = wantedMode;
		// Hide cursor when locking
		Cursor.visible = (CursorLockMode.Locked != wantedMode);
	}

	void Unlock()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Cursor.lockState = wantedMode = CursorLockMode.None;
		}
	}
}
