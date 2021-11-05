using System;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    [SerializeField]private Transform itemsParent;
    InventorySlot[] inventorySlots;
    PlayerInputs playerInputs;

    private void Awake() {
        playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();

                playerInputs.playerInventory.onItemChangedCallback += UpdateUI;
    }

    private void Start() {

        inventorySlots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    public void UpdateUI()
    {
        print("chamou");
        for(int i = 0; i < inventorySlots.Length; i++)
        {
            if(i < playerInputs.playerInventory.items.Count)
            {
                inventorySlots[i].AddItem(playerInputs.playerInventory.items[i]);
            }
            else
            {
                inventorySlots[i].ClearSlot();
            }
        }
    }

}
