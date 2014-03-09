using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnGUI () {
		GUI.backgroundColor = Color.yellow;
		if (GUI.Button (new Rect (Screen.width*0.31f, Screen.height*0.6f , Screen.width/6, Screen.height/7), "PLAY")) {
			Application.LoadLevel("MainGame");
		}
	}
}
