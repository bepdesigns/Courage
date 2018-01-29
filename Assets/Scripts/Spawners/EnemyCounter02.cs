using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounter02 : MonoBehaviour {

	private EnemyManager02 _manager;

	public void Init(EnemyManager02 manager)
	{
		_manager = manager;
	}

	public void OnDestroy()
	{
		_manager.OnEnemyDestroyed(this);
	}
}
