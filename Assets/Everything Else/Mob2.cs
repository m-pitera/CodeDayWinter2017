using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob2 : MonoBehaviour {

	private int mobHealth;

	void start () 
	{
		mobHealth = 3;
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
		if (other.gameObject.tag == "Spell" || other.gameObject.tag == "Player") {
			mobHealth -= 1;
		}
	}
}
