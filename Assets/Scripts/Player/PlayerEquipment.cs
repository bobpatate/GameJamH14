using UnityEngine;
using System.Collections;

public class PlayerEquipment : MonoBehaviour {
	///
	// Les noms: sword, armor, boots, gathering, tier 0 à 3
	///
	public int sword, armor, boots, gathering;

	// Use this for initialization
	void Start () {
		sword = armor = boots = gathering = 2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
