﻿using UnityEngine;
using System.Collections;

public class RessourceStats : MonoBehaviour {
	public float collectingTime;
	public int tier;

	bool harvested;
	float respawnDelay = 30.0f;
	float harvestedAtTime;
	float respawnTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(harvested){

		}
	}

	public void Harvested(){
		harvested = true;
		harvestedAtTime = Time.time;

		//transform.FindChild("Collectile_Trigger").GetComponent<SphereCollider>.enabled = false;
	}
}
