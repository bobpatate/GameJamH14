using UnityEngine;
using System.Collections;

public class EnemyHealthBar_Red : MonoBehaviour {
	
	public GameObject RedBar;
	public float curHealth;
	public float maxHealth;
	
	Transform Player;
	
	EnemyHealth healthScript;
	
	void Awake ()
	{
		
		healthScript = transform.parent.gameObject.GetComponent<EnemyHealth>();
		curHealth = healthScript.curHealth;
		maxHealth = healthScript.maxHealth;
	}
	
	
	void Update () 
	{
		
		curHealth = healthScript.curHealth;
		maxHealth = healthScript.maxHealth;
		
		Vector3 redScale = RedBar.transform.localScale;
		redScale.x = 2 * (maxHealth/maxHealth);
		transform.localScale = redScale;
		
		transform.LookAt(Camera.main.transform);
		
	}
}