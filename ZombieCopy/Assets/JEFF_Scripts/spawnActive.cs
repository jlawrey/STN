using UnityEngine;
using System.Collections;

public class spawnActive : MonoBehaviour {

	public GameObject EnemyManager;

	public float spawnOn = 5f;
	public float spawnOff = 0f;


	// Update is called once per frame
	void Update () 
	{
		spawnOn -= Time.deltaTime;
		if(spawnOn < spawnOff)
		{


			Instantiate(EnemyManager);

		}
	}
}
