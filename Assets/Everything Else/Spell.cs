using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour {

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag != "MagicProjectile" && other.gameObject.tag != "Player"){
			Destroy(gameObject);
		}
	}
}
