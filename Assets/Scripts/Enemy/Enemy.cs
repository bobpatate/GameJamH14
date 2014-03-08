using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	HealthBarEnemy healthBar;

	//stats
	public enum EnemyLevel{ Weak, Intermediate, Strong, SuperStrong, Boss};

	public EnemyLevel level;
	public string team;
	float strength;
	float endurance;
	float speed;
	float hp;

	bool isInBattle = false;
	PlayerCombat player;
	bool playerPlayed = true;
	float nextAttack;

	// Use this for initialization
	void Start () {
		healthBar = gameObject.GetComponent<HealthBarEnemy>();

		//levelstats
		if(level == EnemyLevel.Weak){
			strength = 3.0f;
			endurance = 0.5f;
			speed = 1.0f;
			hp = 20.0f;
		}
		else if(level == EnemyLevel.Intermediate){
			strength = 5.0f;
			endurance = 2.0f;
			speed = 1.4f;
			hp = 35.0f;
		}
		else if(level == EnemyLevel.Strong){
			strength = 8.0f;
			endurance = 3.0f;
			speed = 1.8f;
			hp = 50.0f;
		}
		else if(level == EnemyLevel.SuperStrong){
			strength = 13.0f;
			endurance = 6.0f;
			speed = 2.0f;
			hp = 80.0f;
		}
		else if(level == EnemyLevel.Boss){
			strength = 19.0f;
			endurance = 11.0f;
			speed = 2.3f;
			hp = 130.0f;
		}

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

	public bool ReceivesDamage(float damage){
		hp -= damage-endurance;
		playerPlayed = true;
		healthBar.hp = hp;
		print ("Enemy hp left "  + hp);
		nextAttack = Time.time + 1.5f;

		if(hp <= 0){
			print ("Enemy dead");
			Die();
			return true;
		}

		return false;
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
		healthBar.destroyToi();
		Destroy (this.gameObject);
	}


	public string getTeam(){
		return team;
	}
}
