using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob1 : MonoBehaviour {
	
	private float mobHealth;

	void Start () 
	{
		mobHealth = 1f;
	}

	public void TakeDamage(int pDamage)
	{
		mobHealth -= pDamage;
	}

	public void plzStahp(){
		gameObject.SetActive (false);
	}

	public float GetHealth()
	{
		return mobHealth;
	}

	void Update(){
		if (mobHealth <= 0) {
			plzStahp ();
		}
	}

	void OnCollisionEnter(Collision other){
		var player = new PlayerBehavior ();

		if (other.gameObject.tag == "Player") {
			player.takeDmg (50);
			plzStahp ();
		}
		if (other.gameObject.tag == "MagicProjectile") {
			mobHealth -= 1f;
			player.restoreHealth (5);
			plzStahp ();
		}

	}
}
//bleh
