using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	HealthBarEnemy healthBar;

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
		healthBar = gameObject.GetComponent<HealthBarEnemy>();
		healthBar.maxhp = hp;
		healthBar.hp = hp;

		/*if(team == "Red")
			change asset color
		else
			change asset color
		 */
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
		healthBar.hp = hp;
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
