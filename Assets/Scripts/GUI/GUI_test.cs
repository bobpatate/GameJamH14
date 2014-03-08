using UnityEngine;
using System.Collections;

public class GUI_test : MonoBehaviour {

	public Texture2D iconWepT0;
	public Texture2D iconWepT1;
	public Texture2D iconWepT2;
	public Texture2D iconWepT3;
	public Texture2D iconArmorT0;
	public Texture2D iconArmorT1;
	public Texture2D iconArmorT2;
	public Texture2D iconArmorT3;
	public Texture2D iconBootsT0;
	public Texture2D iconBootsT1;
	public Texture2D iconBootsT2;
	public Texture2D iconBootsT3;
	public Texture2D iconMetalT1;
	public Texture2D iconMetalT2;
	public Texture2D iconMetalT3;
	public Texture2D iconTextilT1;
	public Texture2D iconTextilT2;
	public Texture2D iconTextilT3;
	public Texture2D iconElectronicT1;
	public Texture2D iconElectronicT2;
	public Texture2D iconElectronicT3;

	private Texture2D[] inv = new Texture2D[10];
	
	public GameObject Player1;
	public GameObject Player2;
	
	void OnGUI () {
		PlayerInventory inventoryP1;
		inventoryP1 = Player1.GetComponent<PlayerInventory>();

		for (int i = 0; i < 10; i++) {

		}

		GUI.Box (new Rect (0 ,Screen.height - Screen.height*150/910,Screen.width / 2,Screen.height*150/910), "");
		GUI.Box (new Rect (0 ,Screen.height - Screen.height*180/910,Screen.width*250/1617,Screen.height*30/910), "");
		////
		/// Healtbar
		GUI.Box (new Rect (Screen.width*5/1617, Screen.height  - Screen.height*174/910, Screen.width*240/1617, Screen.height*18/910), "");
		/// 
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*70/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*70/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*130/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*130/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*190/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*190/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*250/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*250/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*310/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*310/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		/// 
		GUI.Box (new Rect (Screen.width*20/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), "");
		GUI.Box (new Rect (Screen.width*140/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), "");
		GUI.Box (new Rect (Screen.width*260/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), "");
		GUI.Box (new Rect (Screen.width*380/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), "");
		////
		/// 
		/// 
		GUI.Box (new Rect (Screen.width / 2 + 1,Screen.height - Screen.height*150/910,Screen.width / 2 -1,Screen.height*150/910), "");
		GUI.Box (new Rect (Screen.width / 2 + 1 ,Screen.height - Screen.height*180/910,Screen.width*250/1617,Screen.height*30/910), "");
		////
		GUI.Box (new Rect ((Screen.width)-Screen.width*70/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.Box (new Rect ((Screen.width)-Screen.width*70/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		GUI.Box (new Rect ((Screen.width)-Screen.width*130/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.Box (new Rect ((Screen.width)-Screen.width*130/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		GUI.Box (new Rect ((Screen.width)-Screen.width*190/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.Box (new Rect ((Screen.width)-Screen.width*190/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		GUI.Box (new Rect ((Screen.width)-Screen.width*250/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.Box (new Rect ((Screen.width)-Screen.width*250/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		GUI.Box (new Rect ((Screen.width)-Screen.width*310/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.Box (new Rect ((Screen.width )-Screen.width*310/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		/// 
		GUI.Box (new Rect (Screen.width / 2 + Screen.width*20/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), "");
		GUI.Box (new Rect (Screen.width / 2 + Screen.width*140/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), "");
		GUI.Box (new Rect (Screen.width / 2 + Screen.width*260/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), "");
		GUI.Box (new Rect (Screen.width / 2 + Screen.width*380/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), "");
	}
}
