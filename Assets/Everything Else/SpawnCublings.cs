using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCublings : MonoBehaviour {

	public GameObject mobPrefab;
	public Transform spawnLocation;

	private GameObject mob;
	private float spawnTime;
	// Use this for initialization
	void Start () {
		spawnTime = 5f;
		InvokeRepeating ("Spawn", 0.1f, spawnTime);

	}

	void Spawn(){
		mob = Instantiate (mobPrefab);
		mob.transform.position = spawnLocation.position;
		if (spawnTime > 2f) {
			spawnTime -= .25f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
