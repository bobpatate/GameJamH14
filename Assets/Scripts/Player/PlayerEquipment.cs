using UnityEngine;
using System.Collections;

public class PlayerEquipment : MonoBehaviour {
	///
	// Les noms: sword, armor, boots, gathering, tier 0 à 3
	///
	public struct Equipment
	{
		public string nom;
		public int tier;
	}

	public Equipment[] equipInventaire = new Equipment[4];

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
