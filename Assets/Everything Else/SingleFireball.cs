using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleFireball : MonoBehaviour {
	//shoot magic boxes from your magic hands. 

	public Transform spawnLocation; //position at which the projectile will be spawned into the world
	public GameObject projectilePrefab; //prefab of a box with a rigidbody and collider component

	private GameObject projectile; //used to store an instance of the projectilePrefab 
	private Rigidbody projBod; //references the rigidbody component on a projectile instance

	public float magicForce; //force with which the projectile will be shot

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Shoot", 0.5f, 8f);//fires fireballs every five seconds
		InvokeRepeating ("Cleanup", 0f, 10f);
	}
	                              
	public void Shoot (){
		projectile = Instantiate (projectilePrefab); //create a new instance of projectilePrefab called projectile
		projBod = projectile.GetComponent<Rigidbody> (); //reference the rigidbody component of the projectile

		projectile.transform.position = spawnLocation.position; //set the position of the projectile to the spawn location near the player

		projBod.AddForce (spawnLocation.forward * magicForce); // Add a force to the rigidbody on projectile in the 
		// forward direction (Blue arrow) of the spawnlocation gameobject
		// this will just fall down unless you multiply it by some force, magicForce.
	}

	// Update is called once per frame
	void Update () {
	}

	void Cleanup(){
		GameObject.Destroy (projectile);
	}

	void OnCollisionEnter(Collision collision){
		projectile.SetActive (false);
	}
}