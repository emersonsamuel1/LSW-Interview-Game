using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    Item item;
    public Image icon;

    [SerializeField]private Button X;

    [SerializeField]GameObject player;

    private void Awake() {
        ClearSlot(); 
    }
    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        X.interactable = true;
    }

    public void ClearSlot ()
    {
        PlayerInputs playerInputs = player.GetComponent<PlayerInputs>();
        playerInputs.playerInventory.RemoveFromInventory(item);
        item = null;
        icon.sprite = null;
        icon.enabled = false;
        X.interactable = false;
         
    }

        public void ClearSlotButton()
    {
        PlayerInputs playerInputs = player.GetComponent<PlayerInputs>();
        playerInputs.playerInventory.RemoveFromInventory(item);
        if(item!=null)Instantiate(item.mySelf,player.transform.position,Quaternion.identity);
        item = null;
        icon.sprite = null;
        icon.enabled = false;
        X.interactable = false;
         
    }

    public void UseItem()
    {
        if(item != null)
        {
            item.Use();
            
        }
    }

}
