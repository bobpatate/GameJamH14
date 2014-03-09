using UnityEngine;
using System.Collections;

public class PlayerEquipment : MonoBehaviour {
	///
	// Les noms: sword, armor, boots, gathering, tier 0 à 3
	///
	public int sword, armor, boots, gathering;

	// Use this for initialization
	void Start () {
		sword = 1;
		armor = 1;
		boots = 1;
		gathering = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
