using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager02 : MonoBehaviour {

	public GameObject enemy;
	public float startDelay = 10f;
	public float spawnTime = 8f;
	public float numOfEnemies = 1;
	public Transform[] spawnPoints;

	private int _totalEnemyCount;

	void Start ()
	{
		InvokeRepeating ("SpawnEnemey", startDelay, spawnTime);
	}

	void SpawnEnemey ()
	{
		if (_totalEnemyCount >= numOfEnemies)
			return;

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		var enemey = Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		enemy.AddComponent<EnemyCounter02>().Init(this);
		_totalEnemyCount++;
	}

	public void OnEnemyDestroyed(EnemyCounter02 enemy)
	{
		_totalEnemyCount--;
	}
}
