using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class SpellShot : MonoBehaviour {

	public Transform spawnLocation; //position at which the projectile will be spawned into the world
	public Transform spawnLocation1;
	public Transform spawnLocation2;
	public Transform spawnLocation3;
	public Transform spawnLocation4;
	public Transform spawnLocation5;
	public GameObject projectilePrefab; //prefab of a box with a rigidbody and collider component

	//public Mob1 mob1;
	//public PlayerBehavior player;
	//public float timeStamp;
	//public float spellStart = 0f;
	//public float spellCooldown = 0.5f;

	private GameObject projectile; //used to store an instance of the projectilePrefab
	private GameObject projectile1;
	private GameObject projectile2;
	private GameObject projectile3;
	private GameObject projectile4;
	private GameObject projectile5;
	private Rigidbody projBod; //references the rigidbody component on a projectile instance
	private Rigidbody projBod1;
	private Rigidbody projBod2;
	private Rigidbody projBod3;
	private Rigidbody projBod4;
	private Rigidbody projBod5;
	//private GameObject theCollidedMob;

	public float magicForce; //force with which the projectile will be shot

	public void Shoot (){
		//if(player.getMana() >= 50){
		//	player.loseMana (50);
			projectile = Instantiate (projectilePrefab); //create a new instance of projectilePrefab called projectile
			projBod = projectile.GetComponent<Rigidbody> (); //reference the rigidbody component of the projectile

			projectile.transform.position = spawnLocation.position; //set the position of the projectile to the spawn location near the player

			projBod.AddForce (spawnLocation.forward * magicForce); // Add a force to the rigidbody on projectile in the 
			// forward direction (Blue arrow) of the spawnlocation gameobject
			// this will just fall down unless you multiply it by some force, magicForce.
		//}
	}

	public void SpreadShot(){
		projectile = Instantiate (projectilePrefab); //create a new instance of projectilePrefab called projectile
		projectile1 = Instantiate (projectilePrefab); //create a new instance of projectilePrefab called projectile
		projectile2 = Instantiate (projectilePrefab); //create a new instance of projectilePrefab called projectile
		projectile3 = Instantiate (projectilePrefab); //create a new instance of projectilePrefab called projectile
		projectile4 = Instantiate (projectilePrefab); //create a new instance of projectilePrefab called projectile
		projectile5 = Instantiate (projectilePrefab); //create a new instance of projectilePrefab called projectile

		projBod = projectile.GetComponent<Rigidbody> ();
		projBod1 = projectile1.GetComponent<Rigidbody> (); //reference the rigidbody component of the projectile
		projBod2 = projectile2.GetComponent<Rigidbody> ();
		projBod3 = projectile3.GetComponent<Rigidbody> ();
		projBod4 = projectile4.GetComponent<Rigidbody> ();
		projBod5 = projectile5.GetComponent<Rigidbody> ();

		projectile.transform.position = spawnLocation.position; 
		projectile1.transform.position = spawnLocation1.position; //set the position of the projectile to the spawn location near the player
		projectile2.transform.position = spawnLocation2.position; 
		projectile3.transform.position = spawnLocation3.position; 
		projectile4.transform.position = spawnLocation4.position; 
		projectile5.transform.position = spawnLocation5.position; 

		projBod.AddForce (spawnLocation.forward * magicForce);
		projBod1.AddForce (spawnLocation1.forward * magicForce); // Add a force to the rigidbody on projectile in the
		projBod2.AddForce (spawnLocation2.forward * magicForce);
		projBod3.AddForce (spawnLocation3.forward * magicForce);
		projBod4.AddForce (spawnLocation4.forward * magicForce);
		projBod5.AddForce (spawnLocation5.forward * magicForce);
	}

	// Update is called once per frame
	//public Text timerText;
	//public Slider timerSlider;
	//public bool active;
	//public float cooldown;
	//public float timer;



	void Update () {
		//if (Time.time > spellStart + spellCooldown) {
		//	spellStart = Time.time;
		//}
		//timeStamp = Time.time + spellCooldown;
	//	if (active) {
	//		timer -= Time.deltaTime;
	//	}
	//	if (timer < 0) {
	//		timer = 0;
	//	}
	//	UpdateUI();

		if (Input.GetButtonDown ("LMB")) {
			Shoot ();
		}
		if (Input.GetButtonDown ("RMB")) {
			SpreadShot ();
		}
	}

	//void UpdateUI()
	//{
	//	timerText.text = "Cooldown: " + timer;
	//	timerSlider.value = (timer / cooldown);
	//}

	//public void CompleteAction()
	//{
	//	if (timer > 0)
	//		return;
	//	active = false;
	//	timer = cooldown;
	//	active = true;
	//}

	//void Cleanup(){
	//	GameObject.Destroy(projectile);
	//}
}



