using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    [SerializeField]internal PlayerInputs playerInputs;

    private void OnTriggerStay2D(Collider2D other) {
        ItemWorld item = other.GetComponent<ItemWorld>();
        if(item != null && playerInputs.interactButton)
        {
            playerInputs.playerInventory.inventory.AddItem(item.GetItem());
            item.DestroySelf();
        }
        else
        {
            return;
        }
    }
}
