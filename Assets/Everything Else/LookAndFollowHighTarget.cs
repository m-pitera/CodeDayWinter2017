using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAndFollowHighTarget : MonoBehaviour {

	private Transform currentPosition;
	public GameObject mobObject;
	public float moveSpeed; //force with which the projectile will be shot
	private GameObject player;

	private Rigidbody projBod; //references the rigidbody component on a projectile instance

	void Start(){
		projBod = mobObject.GetComponent<Rigidbody> (); //reference the rigidbody component of the projectile
		player = GameObject.FindWithTag("HighTarget");
		currentPosition = player.transform;
		InvokeRepeating ("Move", 0f, 0.5f);
	}

	void Move(){
		projBod.AddForce (transform.forward * moveSpeed);
	}

	void FixedUpdate()
	{
		transform.LookAt(currentPosition);
	}
}
