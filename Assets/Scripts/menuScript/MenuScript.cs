using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public Transform menuUI;
	private Transform Camera;
	//public Text gameOverText;
	public Transform unpaused;
	//public Transform Resume;
	CursorLockMode wantedMode;
	// Use this for initialization
	void Start () 
	{ 
		menuUI.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.M)) 
		{
			Cursor.lockState = wantedMode = CursorLockMode.None;
			Cursor.visible = true;
			UnPause ();
		}
	}
	public void UnPause()
	{
		if (menuUI.gameObject.activeInHierarchy == false) 
		{
			menuUI.gameObject.SetActive (true);
			unpaused.gameObject.SetActive (true);
			//Resume.gameObject.SetActive (true);
			Time.timeScale = 0;

		} 
		else
		{
			menuUI.gameObject.SetActive (false);
			unpaused.gameObject.SetActive (false);
			//Resume.gameObject.SetActive (false);
			Time.timeScale = 1;
			//Camera.GetComponent<CharacterController> ().enabled = true;


		}
	}



	public void ExitGame()
	{
		Application.Quit ();
	}
	public void Pause()
	{
		Time.timeScale = 0;
	}
	public void MainMenu(string scene)
	{
		SceneManager.LoadScene( 1, LoadSceneMode.Single);
		Time.timeScale = 1;
	}
	public void Restart(string scene)
	{
		SceneManager.LoadScene( 2, LoadSceneMode.Single);
		Time.timeScale = 1;
	}
}
