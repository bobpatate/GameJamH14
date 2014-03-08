using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//Stats
	float strength = 1.0f;
	float endurance = 0.5f;
	float speed = 1.0f;
	int hp = 100;

	uint level = 1;

	bool isInBattle = false;
	bool ennemyPlayed = true;
	Ennemy ennemy;

	// Use this for initialization
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
		//Normal update

		//Battle update
		if(isInBattle){
			if(ennemyPlayed){
				Attacks();
			}
		}
	}


	//Actions
	void Attacks(){
		ennemy.ReceivesDamage(strength);
	}

	public void ReceivesDamage( float damage ){
		hp -= Mathf.FloorToInt(damage-endurance);
	}


	//States
	bool IsInBattle(){
		return isInBattle;
	}


	//Collisions
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Ennemy"){
			isInBattle = true;
			print("Fightooo!!!");
			ennemy = other.gameObject.GetComponent<Ennemy>();
			other.gameObject.GetComponent<Ennemy>().IsAttacked(this);
		}
	}
}
