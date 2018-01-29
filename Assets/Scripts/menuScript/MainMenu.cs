using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {



	public void MenuScreen (string MenuScreen)
	{
		//SceneManager.LoadScene (MenuScreen);
		SceneManager.LoadScene( 1, LoadSceneMode.Single);
	}

	public void PlayScreen (string PlayScreen)
	{
		SceneManager.LoadScene( 2, LoadSceneMode.Single);
	}

	public void PracticeScreen (string PracticeScreen)
	{
		//SceneManager.LoadScene (MenuScreen);
		SceneManager.LoadScene( 4, LoadSceneMode.Single);
	}

	public void ControlsScreen (string ControlsScreen)
	{
		//SceneManager.LoadScene (MenuScreen);
		SceneManager.LoadScene( 3, LoadSceneMode.Single);
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
