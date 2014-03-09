using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {
	
	public Ressource[] inventaire = new Ressource[10];
	private bool isInCollectingRange = false;
	private bool showCollectTimeBar = false;
	private GameObject collectible;


	private bool isCollecting = false;
	public float ressourceDelay = 4.0f;
	private float collectingStartTime;
	private float collectingTime;

	private float collectTimeBarLenght = 100;
	private GUIStyle currentStyle = null;
	public PlayerController playerControllerScript;

	private bool isInCraftingRange = false;
	private GameObject merchant;
	private string collectibleName;
	// Use this for initialization
	void Start () {
		InitializeInventory();
		playerControllerScript = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (isInCollectingRange)
		{
			if (Input.GetKeyDown(KeyCode.E) && !isCollecting)
			{
				isCollecting = true;
				showCollectTimeBar = true;
				rigidbody.velocity = new Vector3(0,0,0);
				playerControllerScript.enabled = false;

				collectingStartTime = Time.time;
				collectingTime = Time.time + ressourceDelay;
				collectibleName = collectible.name;
			}

			if(isCollecting && Time.time > collectingTime)
				doneCollecting();
		}
		if (isInCraftingRange)
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				RestoreHealthPoints();
				giveInventoryToMerchant(merchant);
			}
		}
	}

	void doneCollecting(){
		isCollecting = false;
		playerControllerScript.enabled = true;
		collectingTime = 0.0f;
		showCollectTimeBar = false;
		isInCollectingRange = false;

		if ( CheckRessourceExisting(collectibleName))
		{
			AddToInventory(collectible);
			Destroy(collectible);
			collectible = null;
		}
	}


	//Collisions
	void OnTriggerEnter(Collider collider) {
		switch(collider.gameObject.name)
		{
		case "Collectible_Trigger" :
			isInCollectingRange = true;
			collectible = collider.transform.parent.gameObject;
			break;
		case "Merchant_Trigger":
			isInCraftingRange = true;
			merchant = collider.transform.parent.gameObject;
			break;
		}
	}

	void OnTriggerExit(Collider collider) {
		switch(collider.gameObject.name)
		{
		case "Collectible_Trigger" :
			isInCollectingRange = false;
			collectible = null;	
			break;
		case "Merchant_Trigger":
			isInCraftingRange = false;
			merchant = null;
			break;
		}
	}


	//GUI
	void OnGUI()
	{
		InitStyles();
		if ( showCollectTimeBar )
		{
			if ( GetComponent<PlayerCombat>().team == "Red" )
			{
				GUI.BeginGroup(new Rect(Screen.width/6 , Screen.height*0.8f, collectTimeBarLenght + 10, 25));
				GUI.Box(new Rect(0,0, collectTimeBarLenght + 10, 25),"Harvesting");
				
				GUI.BeginGroup(new Rect(0,0, collectTimeBarLenght * -((collectingStartTime-Time.time)/ressourceDelay), 20));
				GUI.Box(new Rect(4,4, collectTimeBarLenght, 20),"", currentStyle);
				GUI.EndGroup();
				GUI.EndGroup();
			}
			else
			{
				GUI.BeginGroup(new Rect(Screen.width - (Screen.width / 3) , Screen.height*0.8f, collectTimeBarLenght + 10, 25));
				GUI.Box(new Rect(0,0, collectTimeBarLenght + 10, 25),"Harvesting");
				
				GUI.BeginGroup(new Rect(0,0, collectTimeBarLenght * -((collectingStartTime-Time.time)/ressourceDelay), 20));
				GUI.Box(new Rect(4,4, collectTimeBarLenght, 20),"", currentStyle);
				GUI.EndGroup();
				GUI.EndGroup();
			}
		}
	}

	private void InitStyles()	
	{
		if( currentStyle == null )	
		{
			currentStyle = new GUIStyle( GUI.skin.box );
			currentStyle.normal.background = MakeTex( 2, 2, new Color( 0f, 0.5f, 1f, 0.5f ) );
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


	//Inventory
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

	private void giveInventoryToMerchant(GameObject merchant){
		ItemType itemType = ItemBuilder.Pick(inventaire);
		if (itemType != null) {
			GetComponent<PlayerEquipment>().GiveItem(itemType);
			InitializeInventory();
		}
	}

	private void RestoreHealthPoints(){
		GetComponent<PlayerCombat>().hp = GetComponent<PlayerCombat>().maxhp;
	}
	private bool CheckRessourceExisting(string collectibleName){
		if(GameObject.Find (collectibleName) != null)
			return true;
		else
			return false;
	}
}
