using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour 
{
	public Sprite[] HeatSprites;
	public Image HeatUI;
	private HealthManager healthMan;

	// Use this for initialization
	void Start () {
		healthMan = GetComponent<HealthManager> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		HeatUI.sprite = HeatSprites[healthMan.currentHealth];
	}
}
