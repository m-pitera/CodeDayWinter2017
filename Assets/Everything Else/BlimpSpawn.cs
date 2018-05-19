using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlimpSpawn : MonoBehaviour {

	public GameObject mobPrefab;
	public Transform spawnLocation;
	private float spawnNum;

	private GameObject mob;
	private float spawnTime;
	// Use this for initialization
	void Start () {
		spawnNum = 0f;
		spawnTime = 20f;
		InvokeRepeating ("Spawn", 0.1f, spawnTime);

	}

	void Spawn(){
		if (spawnNum < 2) {
			mob = Instantiate (mobPrefab);
			mob.transform.position = spawnLocation.position;
			if (spawnTime > 7f) {
				spawnTime -= .25f;
			}
			spawnNum++;
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
