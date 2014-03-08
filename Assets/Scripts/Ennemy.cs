using UnityEngine;
using System.Collections;

public class Ennemy : MonoBehaviour {

	//stats
	public enum EnnemyLevel{ Weak, Intermadiate, Strong};

	public EnnemyLevel level;
	float strength = 1.0f;
	float endurance = 0.5f;
	float speed = 1.0f;
	int hp = 100;

	bool isInBattle = false;
	bool playerPlayed = false;
	Player player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}


	//Actions
	void Attacks(){
		player.ReceivesDamage(strength);
	}

	public void ReceivesDamage(float damage){
		hp -= Mathf.FloorToInt(damage-endurance);
		print ("Ennemy received"  + "damage!");
	}


	//States
	public void IsAttacked(Player playerCollided){
		isInBattle = true;
		player = playerCollided;
		print ("Onii-chan, yamete!!!");
	}

	public void CombatEnded(){
		isInBattle = false;
	}
}
