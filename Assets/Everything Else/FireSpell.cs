using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : MonoBehaviour {

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag != "EnemyProjectile"){
			gameObject.SetActive (false);
		}
		if (other.gameObject.tag == "Player") {
			var player = new PlayerBehavior ();
			player.takeDmg (50);
			gameObject.SetActive (false);
		}
	}

}
