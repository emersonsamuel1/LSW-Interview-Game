using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    #region 
    public static PlayerInventory instance;

    
    private void Awake() {
        if(instance != null) Debug.Log("more than one instance of inventory");
        instance = this;
    }
    #endregion

    public delegate void  OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    [SerializeField]private int inventorySpace;
    [SerializeField]internal List<Item> items = new List<Item>();
    public bool AddToInventory(Item item)
    {
        if(items.Count >= inventorySpace) {
            Debug.Log("no room");
            return false;
        }

        items.Add(item);

        if(onItemChangedCallback != null) onItemChangedCallback.Invoke();

        return true;
    }
    public void RemoveFromInventory(Item item)
    {
        items.Remove(item);
    }
}
