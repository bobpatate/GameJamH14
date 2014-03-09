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
	float maxhp;

	bool isInBattle = false;
	PlayerCombat player;
	bool playerPlayed = true;
	float nextAttack;
	
	bool playerSeen = false;
	GameObject playerGO;

	private Transform playerPos;
	private Vector3 targetDirection;
	private Transform myTransform;
	private int force = 1000;

	// Use this for initialization
	void Start () {
		healthBar = gameObject.GetComponent<HealthBarEnemy>();

		myTransform = transform;

		//levelstats
		if(level == EnemyLevel.Weak){
			strength = 3.0f;
			endurance = 0.5f;
			speed = 1.0f;
			hp = 20.0f;
			maxhp = 20.0f;
		}
		else if(level == EnemyLevel.Intermediate){
			strength = 5.0f;
			endurance = 2.0f;
			speed = 1.4f;
			hp = 35.0f;
			maxhp = 35.0f;
		}
		else if(level == EnemyLevel.Strong){
			strength = 8.0f;
			endurance = 3.0f;
			speed = 1.8f;
			hp = 50.0f;
			maxhp = 50.0f;
		}
		else if(level == EnemyLevel.SuperStrong){
			strength = 13.0f;
			endurance = 6.0f;
			speed = 2.0f;
			hp = 80.0f;
			maxhp = 80.0f;
		}
		else if(level == EnemyLevel.Boss){
			strength = 19.0f;
			endurance = 11.0f;
			speed = 2.3f;
			hp = 130.0f;
			maxhp = 130.0f;
		}

		healthBar.maxhp = maxhp;
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

		else if(!isInBattle && playerSeen && playerGO.GetComponent<PlayerCombat>().team != team && !playerGO.GetComponent<PlayerCombat>().IsInBattle()){
			rigidbody.constraints &= ~RigidbodyConstraints.FreezePositionX;
			rigidbody.constraints &= ~RigidbodyConstraints.FreezePositionZ;

			playerPos = playerGO.transform;

			if (playerPos.position.z < 0){
				targetDirection = (playerPos.position - myTransform.position);
			}
			else{
				targetDirection = (playerPos.position - myTransform.position);
			}

			targetDirection = new Vector3(targetDirection.x, 0, targetDirection.z);
			targetDirection.Normalize();
			gameObject.rigidbody.AddForce(targetDirection * force * Time.deltaTime);
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
			Die();
			return true;
		}

		return false;
	}


	//States
	public void IsAttacked(PlayerCombat playerCollided){
		isInBattle = true;
		playerSeen = false;
		player = playerCollided;
		rigidbody.velocity = new Vector3(0,0,0);
		print ("Onii-chan, yamete!!!");
	}

	public void CombatEnded(){
		isInBattle = false;
	}

	void Die(){
		healthBar.destroyToi();
		Destroy (this.gameObject);
	}

	public void PlayerIsDead(){
		hp = maxhp;
		healthBar.hp = maxhp;
	}

	public void PlayerSeen(GameObject player){
		playerGO = player;
		playerSeen = true;
	}
	
	public void PlayerGone(){
		playerSeen = false;
		rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	}

	public string getTeam(){
		return team;
	}
}
