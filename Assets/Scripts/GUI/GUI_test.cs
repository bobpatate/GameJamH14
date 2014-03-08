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
	public Texture2D iconGatT0;
	public Texture2D iconGatT1;
	public Texture2D iconGatT2;
	public Texture2D iconGatT3;
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
	private Texture2D[] inv2 = new Texture2D[10];

	public Texture2D[] equipP1 = new Texture2D[4];
	public Texture2D[] equipP2 = new Texture2D[4];
	
	public GameObject Player1;
	public GameObject Player2;
	
	void OnGUI () {
		PlayerInventory inventoryP1;
		inventoryP1 = Player1.GetComponent<PlayerInventory>();
		PlayerInventory inventoryP2;
		inventoryP2 = Player2.GetComponent<PlayerInventory>();
		PlayerEquipment equipementP1;
		equipementP1 = Player1.GetComponent<PlayerEquipment>();
		PlayerEquipment equipementP2;
		equipementP2 = Player2.GetComponent<PlayerEquipment>();

		for (int i = 0; i < 10; i++) {
			if(inventoryP1.inventaire[i].nom == "Metal" && inventoryP1.inventaire[i].tier == 1){
				inv[i] = iconMetalT1;
			}else if(inventoryP1.inventaire[i].nom == "Metal" && inventoryP1.inventaire[i].tier == 2){
				inv[i] = iconMetalT2;
			}else if(inventoryP1.inventaire[i].nom == "Metal" && inventoryP1.inventaire[i].tier == 3){
				inv[i] = iconMetalT3;
			}else if(inventoryP1.inventaire[i].nom == "Textile" && inventoryP1.inventaire[i].tier == 1){
				inv[i] = iconTextilT1;
			}else if(inventoryP1.inventaire[i].nom == "Textile" && inventoryP1.inventaire[i].tier == 2){
				inv[i] = iconTextilT2;
			}else if(inventoryP1.inventaire[i].nom == "Textile" && inventoryP1.inventaire[i].tier == 3){
				inv[i] = iconTextilT3;
			}else if(inventoryP1.inventaire[i].nom == "Electronique" && inventoryP1.inventaire[i].tier == 1){
				inv[i] = iconElectronicT1;
			}else if(inventoryP1.inventaire[i].nom == "Electronique" && inventoryP1.inventaire[i].tier == 2){
				inv[i] = iconElectronicT2;
			}else if(inventoryP1.inventaire[i].nom == "Electronique" && inventoryP1.inventaire[i].tier == 3){
				inv[i] = iconElectronicT3;
			}else{
				inv[i] = null;
			}

			/// Player 2
			 
			if(inventoryP2.inventaire[i].nom == "Metal" && inventoryP2.inventaire[i].tier == 1){
				inv2[i] = iconMetalT1;
			}else if(inventoryP2.inventaire[i].nom == "Metal" && inventoryP2.inventaire[i].tier == 2){
				inv2[i] = iconMetalT2;
			}else if(inventoryP2.inventaire[i].nom == "Metal" && inventoryP2.inventaire[i].tier == 3){
				inv2[i] = iconMetalT3;
			}else if(inventoryP2.inventaire[i].nom == "Textile" && inventoryP2.inventaire[i].tier == 1){
				inv2[i] = iconTextilT1;
			}else if(inventoryP2.inventaire[i].nom == "Textile" && inventoryP2.inventaire[i].tier == 2){
				inv2[i] = iconTextilT2;
			}else if(inventoryP2.inventaire[i].nom == "Textile" && inventoryP2.inventaire[i].tier == 3){
				inv2[i] = iconTextilT3;
			}else if(inventoryP2.inventaire[i].nom == "Electronique" && inventoryP2.inventaire[i].tier == 1){
				inv2[i] = iconElectronicT1;
			}else if(inventoryP2.inventaire[i].nom == "Electronique" && inventoryP2.inventaire[i].tier == 2){
				inv2[i] = iconElectronicT2;
			}else if(inventoryP2.inventaire[i].nom == "Electronique" && inventoryP2.inventaire[i].tier == 3){
				inv2[i] = iconElectronicT3;
			}else{
				inv2[i] = null;
			}
		}

		if(equipementP1.equipInventaire[0].nom == "sword"){
			if(equipementP1.equipInventaire[0].tier == 0){
				equipP1[0] = iconWepT0;
			}else if(equipementP1.equipInventaire[0].tier == 1){
				equipP1[0] = iconWepT1;
			}else if(equipementP1.equipInventaire[0].tier == 2){
				equipP1[0] = iconWepT2;
			}else if(equipementP1.equipInventaire[0].tier == 3){
				equipP1[0] = iconWepT3;
			}
		}

		if(equipementP1.equipInventaire[1].nom == "armor"){
			if(equipementP1.equipInventaire[1].tier == 0){
				equipP1[1] = iconArmorT0;
			}else if(equipementP1.equipInventaire[0].tier == 1){
				equipP1[1] = iconArmorT1;
			}else if(equipementP1.equipInventaire[0].tier == 2){
				equipP1[1] = iconArmorT2;
			}else if(equipementP1.equipInventaire[0].tier == 3){
				equipP1[1] = iconArmorT3;
			}
		}

		if(equipementP1.equipInventaire[2].nom == "boots"){
			if(equipementP1.equipInventaire[2].tier == 0){
				equipP1[2] = iconBootsT0;
			}else if(equipementP1.equipInventaire[0].tier == 1){
				equipP1[2] = iconBootsT1;
			}else if(equipementP1.equipInventaire[0].tier == 2){
				equipP1[2] = iconBootsT2;
			}else if(equipementP1.equipInventaire[0].tier == 3){
				equipP1[2] = iconBootsT3;
			}
		}

		if(equipementP1.equipInventaire[3].nom == "gathering"){
			if(equipementP1.equipInventaire[3].tier == 0){
				equipP1[3] = iconGatT0;
			}else if(equipementP1.equipInventaire[0].tier == 1){
				equipP1[3] = iconGatT1;
			}else if(equipementP1.equipInventaire[0].tier == 2){
				equipP1[3] = iconGatT2;
			}else if(equipementP1.equipInventaire[0].tier == 3){
				equipP1[3] = iconGatT3;
			}
		}

		/////////
		/// Player 2
		/////////

		if(equipementP2.equipInventaire[0].nom == "sword"){
			if(equipementP2.equipInventaire[0].tier == 0){
				equipP2[0] = iconWepT0;
			}else if(equipementP2.equipInventaire[0].tier == 1){
				equipP2[0] = iconWepT1;
			}else if(equipementP2.equipInventaire[0].tier == 2){
				equipP2[0] = iconWepT2;
			}else if(equipementP2.equipInventaire[0].tier == 3){
				equipP2[0] = iconWepT3;
			}
		}
		
		if(equipementP2.equipInventaire[1].nom == "armor"){
			if(equipementP2.equipInventaire[1].tier == 0){
				equipP2[1] = iconArmorT0;
			}else if(equipementP2.equipInventaire[0].tier == 1){
				equipP2[1] = iconArmorT1;
			}else if(equipementP2.equipInventaire[0].tier == 2){
				equipP2[1] = iconArmorT2;
			}else if(equipementP2.equipInventaire[0].tier == 3){
				equipP2[1] = iconArmorT3;
			}
		}
		
		if(equipementP2.equipInventaire[2].nom == "boots"){
			if(equipementP2.equipInventaire[2].tier == 0){
				equipP2[2] = iconBootsT0;
			}else if(equipementP2.equipInventaire[0].tier == 1){
				equipP2[2] = iconBootsT1;
			}else if(equipementP2.equipInventaire[0].tier == 2){
				equipP2[2] = iconBootsT2;
			}else if(equipementP2.equipInventaire[0].tier == 3){
				equipP2[2] = iconBootsT3;
			}
		}
		
		if(equipementP2.equipInventaire[3].nom == "gathering"){
			if(equipementP2.equipInventaire[3].tier == 0){
				equipP2[3] = iconGatT0;
			}else if(equipementP2.equipInventaire[0].tier == 1){
				equipP2[3] = iconGatT1;
			}else if(equipementP2.equipInventaire[0].tier == 2){
				equipP2[3] = iconGatT2;
			}else if(equipementP2.equipInventaire[0].tier == 3){
				equipP2[3] = iconGatT3;
			}
		}

		GUI.Box (new Rect (0 ,Screen.height - Screen.height*150/910,Screen.width / 2,Screen.height*150/910), "");
		GUI.Box (new Rect (0 ,Screen.height - Screen.height*180/910,Screen.width*250/1617,Screen.height*30/910), "");
		////
		/// Healtbar
		GUI.Box (new Rect (Screen.width*5/1617, Screen.height  - Screen.height*174/910, Screen.width*240/1617, Screen.height*18/910), "");
		/// 
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*70/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), inv[4]);
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*70/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), inv[9]);
		////
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*130/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), inv[3]);
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*130/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), inv[8]);
		////
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*190/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), inv[2]);
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*190/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), inv[7]);
		////
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*250/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), inv[1]);
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*250/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), inv[6]);
		////
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*310/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), inv[0]);
		GUI.Box (new Rect ((Screen.width / 2)-Screen.width*310/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), inv[5]);
		////
		/// 
		GUI.Box (new Rect (Screen.width*20/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), equipP1[0]);
		GUI.Box (new Rect (Screen.width*140/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), equipP1[1]);
		GUI.Box (new Rect (Screen.width*260/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), equipP1[2]);
		GUI.Box (new Rect (Screen.width*380/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), equipP1[3]);
		////
		/// 
		/// 
		GUI.Box (new Rect (Screen.width / 2 + 1,Screen.height - Screen.height*150/910,Screen.width / 2 -1,Screen.height*150/910), "");
		GUI.Box (new Rect (Screen.width / 2 + 1 ,Screen.height - Screen.height*180/910,Screen.width*250/1617,Screen.height*30/910), "");
		////
		GUI.Box (new Rect ((Screen.width)-Screen.width*70/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), inv2[5]);
		GUI.Box (new Rect ((Screen.width)-Screen.width*70/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), inv2[9]);
		////
		GUI.Box (new Rect ((Screen.width)-Screen.width*130/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), inv2[3]);
		GUI.Box (new Rect ((Screen.width)-Screen.width*130/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), inv2[8]);
		////
		GUI.Box (new Rect ((Screen.width)-Screen.width*190/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), inv2[2]);
		GUI.Box (new Rect ((Screen.width)-Screen.width*190/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), inv2[7]);
		////
		GUI.Box (new Rect ((Screen.width)-Screen.width*250/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), inv2[1]);
		GUI.Box (new Rect ((Screen.width)-Screen.width*250/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), inv2[6]);
		////
		GUI.Box (new Rect ((Screen.width)-Screen.width*310/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), inv2[0]);
		GUI.Box (new Rect ((Screen.width )-Screen.width*310/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), inv2[5]);
		////
		/// 
		GUI.Box (new Rect (Screen.width / 2 + Screen.width*20/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), equipP2[0]);
		GUI.Box (new Rect (Screen.width / 2 + Screen.width*140/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), equipP2[1]);
		GUI.Box (new Rect (Screen.width / 2 + Screen.width*260/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), equipP2[2]);
		GUI.Box (new Rect (Screen.width / 2 + Screen.width*380/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), equipP2[3]);
	}
}
