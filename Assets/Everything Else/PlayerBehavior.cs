using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

	public GameObject player;
	public Rigidbody hotBod;
	//public Animator anim;
	public float dashSpeed;
	private static float mana;
	private static float health;
	//int swing;
	//int heal;

	// Use this for initialization
	void Start () {
		//PlayerBehavior player = new PlayerBehavior ();
		//hotBod = player.GetComponent<Rigidbody> ();
		//anim = GetComponent<Animator>();
		//swing = Animator.StringToHash("Swing");
		//mana = 100f;
		health = 100f;
		//InvokeRepeating ("ManaRegen", 0f, 1f);
	}

	/*void ManaRegen () {
		mana += 5f;
		if (mana > 100f)
			mana = 100f;
	}*/

	/*void Mend (){
		if (mana - 50f >= 0) {
			mana -= 50f;
			health += 30f;
			if (health > 100f) {
				health = 100f;
			}
		}
		//anim.setTrigger ("MendHeal");
	}*/

	/*void TeleportLeft () {
		if (mana - 20f >= 0) {
			mana -= 20f;
			hotBod.AddForce (Vector3.left * dashSpeed);
		}
		//if not casted within last 2 seconds, then teleport
	}

	void TeleportRight () {
		if (mana >= 20f) {
			mana -= 20f;
			hotBod.AddForce (Vector3.right * dashSpeed);
		}
		//if not casted within last 2 seconds, then teleport
	}*/

	//void SwordSlash () {
	//	anim.SetTrigger("Attack");
	//}

	//void Magic () {
		//if (mana - 50f >= 0) {
		//	mana -= 50f;
	//		var instance = new SpellShot();
	//		instance.Shoot();
		//}
	//}

	void OnCollisionEnter(Collision other){
		//if (other.gameObject.tag == "Fireball") {
		//	health -= 60;
		//}
	}
	// Update is called once per frame
	void Update () {

		//if (Input.GetButtonDown ("LMB")) {
		//	Invoke ("SwordSlash", 0.45f);
		//}
		/*if (Input.GetButtonDown ("Heal")) {
			Invoke ("Mend", 0f);
		}*/
		/*if (Input.GetButtonDown ("TpRight")) {
			Invoke("TeleportRight", 0f);
		}
		if (Input.GetButtonDown ("TpLeft")) {
			Invoke("TeleportLeft", 0f);
		}*/

	}


	public float getHealth()
	{
		return health;
	}

	public float getMana()
	{
		return mana;
	}
	public void loseMana(float pMana){
		mana -= pMana;
	}
	public void takeDmg(float pHealth){
		health -= pHealth;
	}
	public void restoreHealth(float pHealth){
	if(health < 100){
			health += pHealth;
		}
	}
}
//bleh