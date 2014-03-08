using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// Created by A.Roberts, June 9, 2013
/// 
/// Attach to empty gameObject that is parent to both the green
/// and red planes. Drag green bar into the "greenBar" public
/// field.
/// 
/// </summary>

public class EnemyHealthBar_Green: MonoBehaviour {
	
	public float initialGreenLength;
	public GameObject greenBar;
	public float curHealth;
	public float maxHealth;
	
	public float lastHealth;
	
	Vector3 greenPos;
	
	EnemyHealth healthScript;
	
	public float timer;
	float time = 2;
	
	void Awake ()
	{
		
		//loads enemy health value from healthScript
		healthScript = transform.parent.gameObject.GetComponent<EnemyHealth>();
		curHealth = healthScript.curHealth;
		maxHealth = healthScript.maxHealth;
		
		//stores two health values, will come in later
		lastHealth = curHealth;
	}
	
	
	void Update () 
	{
		
		timer -= Time.deltaTime;
		
		
		if(timer <= 0)
		{
			timer = 0.05f;
			
			// adjusts the greenHealthBar so that as the enemy takes damage
			// the bar shifts to the left, making it appear that the damage
			// is coming off the right side of the bar and not equally from
			// each end.
			
			if(lastHealth > curHealth)
			{
				greenPos = greenBar.transform.localPosition;
				greenPos.x = (lastHealth - curHealth)/curHealth;
				greenBar.transform.localPosition = greenPos;
				lastHealth = curHealth;
			}
		}
		
		curHealth = healthScript.curHealth;
		maxHealth = healthScript.maxHealth;
		
		// C# conversion of Professor Snake's awesome code from Unity forum's
		// http://answers.unity3d.com/questions/403008/help-with-enemy-health-bars.html
		
		Vector3 greenScale = greenBar.transform.localScale;
		greenScale.x = 2 * (curHealth/maxHealth);
		greenScale.y = greenScale.y;
		transform.localScale = greenScale;
		
		//keeps bar facing camera
		transform.LookAt(Camera.main.transform);
		
	}
}