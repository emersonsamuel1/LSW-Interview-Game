using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    internal Inventory inventory;
    [SerializeField]private UI_Inventory uiInventory;
    [SerializeField]private PlayerInputs playerInputs;

    private void Awake() {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

         ItemWorld.SpawnItemWorld(new Vector2(0,0), new Item {itemType = Item.ItemType.BlueDress, amount = 1});
    }
}
