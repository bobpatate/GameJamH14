using UnityEngine;
using System.Collections;

public class PlayerCombat : MonoBehaviour {

	//Stats
	float strength = 5.0f;
	float endurance = 1.0f;
	float speed = 1.0f;
	float hp = 100.0f;
	public string team;

	bool isInBattle = false;
	bool enemyPlayed = true;
	float nextAttack;
	Enemy enemy;

	// Use this for initialization
	void Start () {
		nextAttack = Time.time + 1.5f;
	}


	// Update is called once per frame
	void Update () {
		//Normal update

		//Battle update
		if(isInBattle && enemyPlayed && Time.time > nextAttack){
			nextAttack = Time.time + 1.5f;
			enemyPlayed = false;
			Attacks();
		}
	}


	//Actions
	void Attacks(){
		enemy.ReceivesDamage(strength);
	}

	public void ReceivesDamage( float damage ){
		enemyPlayed = true;
		hp -= damage-endurance;
		print ("Player hp left "  + hp);

		if(hp <= 0){
			print ("You dead");
			Respawn();
		}
	}


	//States
	public bool IsInBattle(){
		return isInBattle;
	}

	void Respawn(){

	}


	//Collisions
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Enemy" && !isInBattle){
			if(other.gameObject.GetComponent<Enemy>().getTeam() != team){
				isInBattle = true;
				print("Fightooo!!!");
				enemy = other.gameObject.GetComponent<Enemy>();
				other.gameObject.GetComponent<Enemy>().IsAttacked(this);
			}
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.tag == "Enemy" && isInBattle){
			isInBattle = false;
			print("Soyonara!!!");
			enemy = null;
			other.gameObject.GetComponent<Enemy>().CombatEnded();
		}
	}
}
