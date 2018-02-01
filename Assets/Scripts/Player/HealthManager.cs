using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour 
{
	public int maxHealth;
	public int currentHealth;

	//public PlayerController thePlayer;
	public Character3rdPerson thePlayer;

	public float invncibilityLength;
	public float invincibilityCounter;

	public Renderer playerRenderer;
	private float flashCounter;
	public float flashLength = 0.01f;

	private bool IsRespawning;
	private Vector3 respawnPoint;

	public float respawnLegth;

	public GameObject deathEffect;
	public Image blackScreen;
	private bool IsFadeToBlack;
	private bool IsFadeFromBlack;
	public float fadeSpeed;
	public float waitForFade;

	// Use this for initialization
	void Start () 
	{
		currentHealth = maxHealth;
		//thePlayer = FindObjectOfType<PlayerController> ();
		thePlayer = this.GetComponent<Character3rdPerson> ();
		respawnPoint = thePlayer.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (invincibilityCounter > 0) 
		{
			invincibilityCounter -= Time.deltaTime;

			flashCounter -= Time.deltaTime;
			if (flashCounter <= 0) 
			{
				playerRenderer.enabled = !playerRenderer.enabled;
				flashCounter = flashLength;
			}

			if (invincibilityCounter <= 0) 
			{
				playerRenderer.enabled = true;
			}
		}

		if (IsFadeToBlack) 
		{
			blackScreen.color = new Color (blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards (blackScreen.color.a, 1f, fadeSpeed * Time.deltaTime));
			if (blackScreen.color.a == 1f) 
			{
				IsFadeToBlack = false;
			}
		}

		if (IsFadeFromBlack) 
		{
			blackScreen.color = new Color (blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards (blackScreen.color.a, 0f, fadeSpeed * Time.deltaTime));
			if (blackScreen.color.a == 0f) 
			{
				IsFadeFromBlack = false;
			}
		}
	}
	public void HurtPlayer(int damage, Vector3 direction)
	{
		if (invincibilityCounter <= 0) 
		{
			currentHealth -= damage;

			if (currentHealth <= 0) 
			{
				Respawn ();
			} 
			else 
			{

				//thePlayer.Knocback (direction);
				invincibilityCounter = invncibilityLength;

				playerRenderer.enabled = false;
				flashCounter = flashLength;	
			}

		}
	}

	public void Respawn()
	{
		//thePlayer.transform.position = respawnPoint;
		//currentHealth = maxHealth;

		if (!IsRespawning) 
		{
			StartCoroutine ("Respawner");
		}
	}

	public IEnumerator Respawner()
	{
		IsRespawning = true;
		thePlayer.gameObject.SetActive (false);
		Instantiate (deathEffect, thePlayer.transform.position, thePlayer.transform.rotation);

		yield return new WaitForSeconds (respawnLegth);

		IsFadeToBlack = true;

		yield return new WaitForSeconds (waitForFade);

		IsFadeToBlack = false;
		IsFadeFromBlack = true;

		IsRespawning = false;

		thePlayer.gameObject.SetActive (true);
		thePlayer.transform.position = respawnPoint;
		currentHealth = maxHealth;

		invincibilityCounter = invncibilityLength; 
		playerRenderer.enabled = false;
		flashCounter = flashLength;	

	}

	public void HealPlayer(int healAmount)
	{
		currentHealth = maxHealth;

		if(currentHealth > maxHealth)
			{
			currentHealth = maxHealth;
		}
	}

	public void SetSpawnPoint(Vector3 newPosition)
	{
		respawnPoint = newPosition;
	}
}
