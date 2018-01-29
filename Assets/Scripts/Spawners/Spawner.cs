using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject Enemy = null;

	public int hazardCount = 3;
	public float spawnWait=10f;
	public float startWait=4f;
	public float waveWait=8f;            
	public Transform[] spawnPoints; 

	void Start ()
	{
		StartCoroutine(SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true) {
			// Only pick a new spawn point once per wave
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);

			for (int i = 0; i < hazardCount; i++) {
				// here would pick a new spawn point for each new enemy
				Instantiate (Enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);

				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}
