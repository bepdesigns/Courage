using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControls : MonoBehaviour {


	public GameObject keyboardIcons;
	public GameObject gamePadIcons;


	// Use this for initialization
	void Start () {
		keyboardIcons.SetActive (true);
		gamePadIcons.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () 

	{
		if(Input.GetKeyDown(KeyCode.Q))
		{
			WeaponSwitcher ();
		}
	}
	void WeaponSwitcher()
	{
		if (keyboardIcons.activeSelf) {
			keyboardIcons.SetActive (false);
			gamePadIcons.SetActive (true);

		} else if(gamePadIcons.activeSelf){
			gamePadIcons.SetActive (false);
			keyboardIcons.SetActive (true);
		}
	}
}
