using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob3 : MonoBehaviour {

	private float mob3Health;

	void start () 
	{
		
		mob3Health = 5f;
	}

	public void TakeDamage(int pDamage)
	{
		mob3Health -= pDamage;
	}

	public void plzStahp(){
		gameObject.SetActive (false);
	}

	public float GetHealth()
	{
		return mob3Health;
	}

	void Update(){
		//if (mob3Health <= 0) {
		//	Destroy (gameObject);
		//}
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "MagicProjectile") {
			mob3Health -= 1f;

		}
	}
}
