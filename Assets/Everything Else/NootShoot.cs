using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NootShoot : MonoBehaviour {

	public Transform spawnLocation; //position at which the projectile will be spawned into the world
	public GameObject projectilePrefab; //prefab of a box with a rigidbody and collider component
	private GameObject projectile; //used to store an instance of the projectilePrefab
	private Rigidbody projBod; //references the rigidbody component on a projectile instance
	public float nootons; //force with which the projectile will be shot
	public Transform target;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("NooShoot", 0.01f, 5f);
	}

	public void NooShoot (){
		//if(player.getMana() >= 50){
		//	player.loseMana (50);
		projectile = Instantiate (projectilePrefab); //create a new instance of projectilePrefab called projectile
		projBod = projectile.GetComponent<Rigidbody> (); //reference the rigidbody component of the projectile

		projectile.transform.position = spawnLocation.position; //set the position of the projectile to the spawn location near the player

		projBod.AddForce (spawnLocation.forward * nootons); // Add a force to the rigidbody on projectile in the 
		// forward direction (Blue arrow) of the spawnlocation gameobject
		// this will just fall down unless you multiply it by some force, magicForce.
		//}
	}
	
	// Update is called once per frame
	void Update () {
		if(target != null)
		{
			transform.LookAt(target);
		}
	}
}
