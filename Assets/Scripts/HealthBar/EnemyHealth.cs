using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	
	public float maxHealth = 100;
	public float curHealth = 100;
	
	public Transform ticketPrefab;
	
	public float healthBarLength;
	
    bool showHealthBar = true;

	public GameObject greenBar;
	public GameObject redBar;
	
	void Start()
	{
		healthBarLength = Screen.width /2;
		showHealthBar = false;
	}
	
	
	//  void OnTriggerEnter(Collider other)
	//   {
	
	//   if(other.collider.tag == "Player")
	//       {
	//       showHealthBar = true;}
	
	//   }
	
	//  void OnTriggerExit(Collider other)
	//   {
	
	//   if(other.collider.tag == "Player")
	//       {
	//       showHealthBar = false;}
	//   }
	
	
	public void AdjustCurrentHealth(int adj)
	{
		
		curHealth += adj;
		
		if(curHealth < 0)
			curHealth = 0;
		
		if(curHealth == 0)
		{
			Destroy(gameObject);
			Instantiate(ticketPrefab, transform.position, transform.rotation);
		}
		
		if(curHealth > maxHealth)
			curHealth = maxHealth;
		
		if(maxHealth < 1)
			maxHealth = 1;
		
		healthBarLength = (Screen.width / 2) * (curHealth / (float)maxHealth);
	}
	
	void Update() 
	{
		AdjustCurrentHealth(0);
		
		if(showHealthBar)
		{
			greenBar.renderer.enabled = true;
			redBar.renderer.enabled = true;
		}
		
		else 
		{
			greenBar.renderer.enabled = false;
			redBar.renderer.enabled = false;
		}
	}
}