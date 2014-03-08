﻿using UnityEngine;
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

	void OnGUI () {
		GUIStyle myStyle = new GUIStyle();
		myStyle.fontSize = 12;
		myStyle.normal.textColor = Color.white;
		//GUI.TextArea (new Rect (0,Screen.height - 50,100,50), "Arme: \nCorp: \nPied: ");
		GUI.TextArea (new Rect (Screen.width / 2 + 1,Screen.height - Screen.height*150/910,Screen.width / 2 -1,Screen.height*150/910), "");
		GUI.TextArea (new Rect (0 ,Screen.height - Screen.height*150/910,Screen.width / 2,150), "");
		////
		GUI.TextArea (new Rect ((Screen.width / 2)-Screen.width*70/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.TextArea (new Rect ((Screen.width / 2)-Screen.width*70/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		GUI.TextArea (new Rect ((Screen.width / 2)-Screen.width*130/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.TextArea (new Rect ((Screen.width / 2)-Screen.width*130/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		GUI.TextArea (new Rect ((Screen.width / 2)-Screen.width*190/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.TextArea (new Rect ((Screen.width / 2)-Screen.width*190/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		GUI.TextArea (new Rect ((Screen.width / 2)-Screen.width*250/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.TextArea (new Rect ((Screen.width / 2)-Screen.width*250/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		GUI.TextArea (new Rect ((Screen.width / 2)-Screen.width*310/1617 ,Screen.height - Screen.height*130/910,Screen.width*50/1617,Screen.height*50/910), "");
		GUI.TextArea (new Rect ((Screen.width / 2)-Screen.width*310/1617 ,Screen.height - Screen.height*70/910,Screen.width*50/1617,Screen.height*50/910), "");
		////
		/// 
		GUI.TextArea (new Rect (Screen.width*20/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), "");
		GUI.TextArea (new Rect (Screen.width*140/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), "");
		GUI.TextArea (new Rect (Screen.width*260/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), "");
		GUI.TextArea (new Rect (Screen.width*380/1617 ,Screen.height - Screen.height*130/910,Screen.width*110/1617,Screen.height*110/910), "");
	}
}