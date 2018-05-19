using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour 
{
	public Animator anim;
	int scream;
	int basicAttack;
	int getHit;
	int walk;
	int die;
	bool death = false;
	private static float boss1Health = 300f;
	//int dieRebelScum;
	public Transform target;

	void start () 
	{
		anim = gameObject.GetComponent<Animator>();
		scream = Animator.StringToHash("Scream");
		basicAttack = Animator.StringToHash("Basic Attack");
		getHit = Animator.StringToHash("Get Hit");
		walk = Animator.StringToHash("Walk");
	//	dieRebelScum = Animator.StringToHash ("Die");
		InvokeRepeating("BasicAttack", 0f, 5f);
		boss1Health = 500f;
	}

	public void Scream ()
	{
		anim.SetTrigger(scream);
		var instance = new TripleFireball();
		instance.Shoot();
	}

	public void BasicAttack ()
	{
		anim.SetTrigger(basicAttack);
		var instance = new SingleFireball();
		instance.Shoot();
	}

	public void GetHit (Collision other)
	{
		if (other.gameObject.tag == "MagicProjectile"){
			int randValue = (int)(Random.value * 10);
			if (randValue <= 5) {
				anim.SetTrigger (getHit);
			}}
		if (other.gameObject.tag == "Sword"){
			int randValue = (int)(Random.value * 12);
			if (randValue <= 3) {
				anim.SetTrigger (getHit);
			}}

	}

	public void Walk ()
	{
		anim.SetTrigger(walk);
	}

	public void Death ()
	{
		if (boss1Health <= 0) {
			death = true;
		}
		if (death == true) {
			anim.SetTrigger ("dieRebelScum");
			Invoke("plzStahp", 1f);
		}
	}

	public void lowerBoss1Health(int pDamage)
	{
		boss1Health -= pDamage;
	}

	void plzStahp(){
		gameObject.SetActive (false);

	}

	//	public void randAttack()
	//	{
	//		int randValue = (int)(Random.value * 11);
	//		if (randValue <= 5) {
	//			BasicAttack ();
	//		}
	//		else if (randValue <= 8) {
	//			Scream ();
	//		}


	//	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Sword") {
			boss1Health -= 30;
		}
		if (other.gameObject.tag == "MagicProjectile") {
			boss1Health -= 50;
		}
	}

	public float GetHealth()
	{
		return boss1Health;
	}

	void Update(){
		if (boss1Health <= 0) {
			Invoke ("Death", 0.5f);
			//hide;
		}
		transform.LookAt(target);
	}
}



