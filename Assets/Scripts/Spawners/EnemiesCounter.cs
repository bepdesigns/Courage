using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesCounter : MonoBehaviour {
	// Use this for initialization


	public Text text;

	int enemiesLeft = 0;

	bool killedAllEnemies = false;

	void Start () {
		enemiesLeft = 0; // or whatever;
		text.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		text.enabled = true;

		text.text = "" + enemiesLeft;
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
		enemiesLeft = enemies.Length;

		if(Input.GetKeyDown(KeyCode.A))
		{
			enemiesLeft --;
		}

		if(enemiesLeft == 0)
		{
			endGame();
		}
	}

	void endGame()
	{
		killedAllEnemies = true;
	}

	/*void OnGUI()
	{
		if(killedAllEnemies)
		{
			GUI.Label(new Rect (0,0,200,20),"all gone");
		}
		else
		{
			GUI.Label(new Rect (0,0,200,20),"Enemies Remaining : " + enemiesLeft);
		}
	}*/
}
