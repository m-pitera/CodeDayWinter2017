using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGUI2 : MonoBehaviour {
	private bool isDead = false;
	private double deathTime;
	public PlayerBehavior player = new PlayerBehavior();
	//playerControl boss1 = new playerControl ();
	//boss2 theSecondBoss = new boss2 ();
	// //playerControl boss2 = new playerControl ();
	//float boss1Health;
	//float boss2Health;
	//float bossHealth;
	//bool bossIsDead;
	//bool boss2IsDead;

	// Use this for initialization
	void OnGUI () {
	//	boss2IsDead = false;
	//	boss1Health = boss1.GetHealth ();
	//	boss2Health = theSecondBoss.GetHealth ();
	//	//boss2Health = boss2Health.GetHealth ();
	//	bossHealth = boss1Health;
	//	//if (bossIsDead)
	//	//bossHealth = boss2Health;
		GUI.Box(new Rect(10,10,150,70), "Stats\n Health: " + player.getHealth()+"\nTime: " + Time.time);
		if (player.getHealth () <= 0 || isDead)
	     {
			isDead = true;
			deathTime = Time.fixedTime;
			for(int i = 0; i < 11; i++){
				GUI.Box (new Rect (-10, 0, 1600, 150), "");
				GUI.Box (new Rect (-10, 150, 1600, 700), "GAME OVER\t\n" + "Amount Survived: " + deathTime);
			}
		}
	
	}

}

