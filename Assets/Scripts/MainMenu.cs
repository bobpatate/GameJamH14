using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnGUI () {
		GUI.backgroundColor = Color.yellow;
		if (GUI.Button (new Rect (Screen.width/2,Screen.height,150,70), "PLAY")) {
			Application.LoadLevel("MainGame");
		}
	}
}
