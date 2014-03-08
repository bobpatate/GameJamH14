using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	//stats
	public enum EnemyLevel{ Weak, Intermadiate, Strong};

	public EnemyLevel level;
	public string team;
	float strength = 3.0f;
	float endurance = 0.5f;
	float speed = 1.0f;
	float hp = 20.0f;

	bool isInBattle = false;
	PlayerCombat player;
	bool playerPlayed = true;
	float nextAttack;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(isInBattle && playerPlayed && Time.time > nextAttack){
			playerPlayed = false;
			Attacks ();
		}
	}


	//Actions
	void Attacks(){
		player.ReceivesDamage(strength);
	}

	public void ReceivesDamage(float damage){
		hp -= damage-endurance;
		playerPlayed = true;
		print ("Enemy hp left "  + hp);
		nextAttack = Time.time + 1.5f;

		if(hp <= 0){
			print ("Enemy dead");
			Die();
		}
	}


	//States
	public void IsAttacked(PlayerCombat playerCollided){
		isInBattle = true;
		player = playerCollided;
		print ("Onii-chan, yamete!!!");
	}

	public void CombatEnded(){
		isInBattle = false;
	}
	void Die(){
		Destroy(this.gameObject);
	}


	public string getTeam(){
		return team;
	}
}
