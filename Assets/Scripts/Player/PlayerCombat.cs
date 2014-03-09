using UnityEngine;
using System.Collections;

public class PlayerCombat : MonoBehaviour {

	//Stats
	public float strength = 5.0f;
	public float endurance = 1.0f;
	public float speed = 1.0f;
	public float maxhp = 15.0f;
	public float hp = 15.0f;

	public string team;

	bool isInBattle = false;
	bool enemyPlayed = true;
	float nextAttack;
	Enemy enemy;

	float tempsRespawn = 5.0f;

	PlayerController playerControllerScript;

	// Use this for initialization
	void Start () {
		nextAttack = Time.time + 1.5f;

		playerControllerScript = GetComponent<PlayerController>();
	}


	// Update is called once per frame
	void Update () {
		//Battle update
		if(isInBattle && enemyPlayed && Time.time > nextAttack){
			nextAttack = Time.time + 1.5f;
			enemyPlayed = false;
			Attacks();
		}
	}


	//Actions
	void Attacks(){
		if(enemy.ReceivesDamage(strength)){
			playerControllerScript.enabled = true;
			isInBattle = false;
		}
	}

	public void ReceivesDamage( float damage ){
		enemyPlayed = true;
		hp -= damage-endurance;
		print ("Player hp left "  + hp);

		if(hp <= 0){
			print ("You dead");
			enemy.PlayerIsDead();
			Respawn();
		}
	}


	//States
	public bool IsInBattle(){
		return isInBattle;
	}

	void Respawn(){
		isInBattle = false;
		playerControllerScript.enabled = true;
		hp = maxhp;

		gameObject.transform.position = GameObject.Find("Merchant").transform.position + Vector3.forward*2;
	}


	//Collisions
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "Fight_Trigger" && !isInBattle){
			if(other.gameObject.transform.parent.GetComponent<Enemy>().getTeam() != team){
				rigidbody.velocity = new Vector3(0,0,0);
				playerControllerScript.enabled = false;
				isInBattle = true;
				print("Fightooo!!!");
				enemy = other.gameObject.transform.parent.GetComponent<Enemy>();
				other.gameObject.transform.parent.GetComponent<Enemy>().IsAttacked(this);
			}
		}

		else if(other.gameObject.name == "Detection_Trigger"){
			other.transform.parent.gameObject.GetComponent<Enemy>().PlayerSeen(gameObject);
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.name == "Fight_Trigger" && isInBattle){
			isInBattle = false;
			print("Soyonara!!!");
			enemy = null;
			other.gameObject.transform.parent.GetComponent<Enemy>().CombatEnded();
		}

		else if(other.gameObject.name == "Detection_Trigger"){
			other.transform.parent.gameObject.GetComponent<Enemy>().PlayerGone();
		}
	}
}
