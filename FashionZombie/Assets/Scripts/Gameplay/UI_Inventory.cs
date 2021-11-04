using System;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    [SerializeField]private Transform itemsParent;
    InventorySlot[] inventorySlots;
    PlayerInventory playerInventory;

    private void Awake() {
        playerInventory = PlayerInventory.instance;
    }

    private void Start() {
        playerInventory.onItemChangedCallback += UpdateUI;

        inventorySlots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    public void UpdateUI()
    {
        for(int i = 0; i < inventorySlots.Length; i++)
        {
            if(i < playerInventory.items.Count)
            {
                inventorySlots[i].AddItem(playerInventory.items[i]);
            }
            else
            {
                inventorySlots[i].ClearSlot();
            }
        }
    }

}
