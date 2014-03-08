using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {

	private struct Ressource
	{
		public string nom;
		public int tier;
	}

	private Ressource[] inventaire = new Ressource[10];
	private bool isInCollectingRange = false;
	private bool showCollectTimeBar = false;
	private GameObject collectible;
	private float collectingTime = 0.0f;
	private float ressourceTime = 100.0f;
	private float collectTimeBarLenght;
	private float currentCollectTime;
	private GUIStyle currentStyle = null;
	public PlayerController playerControllerScript;

	// Use this for initialization
	void Start () {
		currentCollectTime = 0.0f;
		InitializeInventory();
		playerControllerScript = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (isInCollectingRange)
		{
			print ("InCollectingRange");
			if (Input.GetKeyDown(KeyCode.E))
			{
				print (collectible.name);
				showCollectTimeBar = true;
				collectTimeBarLenght = ressourceTime;
				playerControllerScript.enabled = false;
				print (ressourceTime);
				while (currentCollectTime < ressourceTime)
				{
					currentCollectTime += Time.time*0.05f;
				}
				playerControllerScript.enabled = true;
				currentCollectTime = 0.0f;
				showCollectTimeBar = false;
				isInCollectingRange = false;
				AddToInventory(collectible);
				Destroy(collectible);
				collectible = null;
			}
		}
	}

	void OnTriggerEnter(Collider collider) {
		switch(collider.gameObject.name)
		{
		case "Collectible_Trigger" :
			print("OnTriggerEnter");
			isInCollectingRange = true;
			collectible = collider.transform.parent.gameObject;
			break;
		}
	}

	void OnTriggerExit(Collider collider) {
		switch(collider.gameObject.name)
		{
		case "Collectible_Trigger" :
			print("OnTriggerExit");
			isInCollectingRange = false;
			collectible = null;	
			break;
		}
	}

	void OnGUI()
	{
		InitStyles();
		if ( showCollectTimeBar )
		{
			//GUI.Box (new Rect(Screen.width/2 - collectTimeBarLenght / 2,600,collectTimeBarLenght + 10,15),"" );             //Fond de la barre de recolte
			//GUI.Box (new Rect(Screen.width/2 - collectTimeBarLenght / 2 + 10,602,currentCollectTime,10),"",currentStyle ); //Barre de recolte
			GUI.BeginGroup(new Rect(Screen.width/2 - collectTimeBarLenght / 2, 600, collectTimeBarLenght + 10, 15));
			GUI.Box(new Rect(0,0, collectTimeBarLenght + 10, 15),"");
			
			//draw the filled-in part:
			GUI.BeginGroup(new Rect(0,0, collectTimeBarLenght * currentCollectTime, 10));
			GUI.Box(new Rect(0,0, collectTimeBarLenght, 10),"", currentStyle);
			GUI.EndGroup();
			GUI.EndGroup();
		}
	}

	private void InitStyles()	
	{
		if( currentStyle == null )	
		{
			currentStyle = new GUIStyle( GUI.skin.box );
			currentStyle.normal.background = MakeTex( 2, 2, new Color( 0f, 1f, 0f, 0.5f ) );
		}
		
	}

	private Texture2D MakeTex( int width, int height, Color col )	
	{
		
		Color[] pix = new Color[width * height];
		for( int i = 0; i < pix.Length; ++i )	
		{
			pix[ i ] = col;
		}
		Texture2D result = new Texture2D( width, height );
		result.SetPixels( pix );
		result.Apply();
		return result;
	}

	private void AddToInventory(GameObject collectible){
		if (!CheckInventoryFull())
		{
			for (int i = 0; i < 10; i++)
			{
				if ( inventaire[i].nom == "" )
				{
					inventaire[i].nom = collectible.name;
					inventaire[i].tier = collectible.GetComponent<RessourceStats>().tier;
					print ("Successfully added to inventory : " + inventaire[i].nom + " " + inventaire[i].tier);
					return;
				}
			}
		}
		else
			print ("Inventory is full");
	}

	public void InitializeInventory(){
		for ( int i = 0; i < 10; i++ )
		{
			inventaire[i].nom = "";
			inventaire[i].tier = -1;

		}
	}

	//Fonction qui retourne vrai si l'inventaire est plein
	private bool CheckInventoryFull(){

		for (int i = 0; i < 10; i++)
		{
			if ( inventaire[i].nom == "" )
			{
				return false;
			}
		}
		return true;
	}

}
