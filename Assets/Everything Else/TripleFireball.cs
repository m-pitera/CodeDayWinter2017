using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleFireball : MonoBehaviour {
	//shoot magic boxes from your magic hands.

	public Transform spawnLocation1; //position at which the projectile will be spawned into the world
	public Transform spawnLocation2; //position at which the projectile will be spawned into the world
	public Transform spawnLocation3; //position at which the projectile will be spawned into the world
	public GameObject projectilePrefab; //prefab of a box with a rigidbody and collider component

	private GameObject projectile1; //used to store an instance of the projectilePrefab
	private GameObject projectile2; //used to store an instance of the projectilePrefab 
	private GameObject projectile3; //used to store an instance of the projectilePrefab 
	private Rigidbody projBod; //references the rigidbody component on a projectile instance

	public float magicForce; //force with which the projectile will be shot

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Shoot", 0.5f, 5f);//fires fireballs every five seconds
		projectile1 = Instantiate (projectilePrefab); //create a new instance of projectilePrefab called projectile
		projectile2 = Instantiate (projectilePrefab); //create a new instance of projectilePrefab called projectile
		projectile3 = Instantiate (projectilePrefab); //create a new instance of projectilePrefab called projectile
	}

	public void Shoot (){
		
		projBod = projectile1.GetComponent<Rigidbody> (); //reference the rigidbody component of the projectile
		projBod = projectile2.GetComponent<Rigidbody> (); //reference the rigidbody component of the projectile
		projBod = projectile3.GetComponent<Rigidbody> (); //reference the rigidbody component of the projectile

		projectile1.transform.position = spawnLocation1.position;
		projectile2.transform.position = spawnLocation2.position;
		projectile3.transform.position = spawnLocation3.position;//set the position of the projectile to the spawn location near the player

		projBod.AddForce (spawnLocation1.forward * magicForce);
		projBod.AddForce (spawnLocation2.forward * magicForce);
		projBod.AddForce (spawnLocation3.forward * magicForce);
		// Add a force to the rigidbody on projectile in the 
		// forward direction (Blue arrow) of the spawnlocation gameobject
		// this will just fall down unless you multiply it by some force, magicForce.
	}

	// Update is called once per frame
	void Update () {
	}




}