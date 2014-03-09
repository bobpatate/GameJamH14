using UnityEngine;
using System.Collections;

public class PlayerEquipment : MonoBehaviour {
	///
	// Les noms: sword, armor, boots, gathering, tier 0 à 3
	///
    public int sword { get { return items[(int)Slots.Weapon].Tier; } }
    public int armor { get { return items[(int)Slots.Armor].Tier; } }
    public int boots { get { return items[(int)Slots.Boots].Tier; } }
    public int gathering { get { return items[(int)Slots.Tool].Tier; } }

    private ItemType[] items = new ItemType[4];

	void Start () {
        items[(int)Slots.Weapon] = ItemType.WeaponT0;
        items[(int)Slots.Armor] = ItemType.ArmorT0;
        items[(int)Slots.Boots] = ItemType.BootsT0;
        items[(int)Slots.Tool] = ItemType.ToolT0;
        this.UpdateStats();
	}

    private void UpdateStats()
    {
        Stats stats = ItemType.CalculateStats(items);

        PlayerCombat playerCombat = GetComponent<PlayerCombat>();
        playerCombat.strength = stats.Damage;
        playerCombat.maxhp = playerCombat.hp = stats.HP;

        PlayerInventory playerInventory = GetComponent<PlayerInventory>();
        playerInventory.ressourceDelay = 4.0f / stats.GatheringSpeed;

        PlayerController playerController = GetComponent<PlayerController>();
        playerController._speed = playerController._maxVelocityChange = 5.0f * stats.MovementSpeed;
    }

    public void GiveItem(ItemType item)
    {
        int slot = (int)item.Slot;
        if (items[slot].Tier < item.Tier)
        {
            items[slot] = item;
            this.UpdateStats();
        }
    }
}
