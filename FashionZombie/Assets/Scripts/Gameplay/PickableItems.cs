using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItems : MonoBehaviour,IPickable
{
    [SerializeField]private Item item;
    public void Picked()
    {
        bool wasPickedUp =PlayerInventory.instance.AddToInventory(item);

        if(wasPickedUp) Destroy(gameObject);
    }
}
