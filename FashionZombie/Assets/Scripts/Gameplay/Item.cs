using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item
{
    public enum ItemType
    {
        Money,
        BlueDress,
        Jeans,
        Hat
    }

    public ItemType itemType;
    public int amount;


    public Sprite GetSprite()
    {
        switch (itemType) {
            default:    
            case ItemType.BlueDress: return ItemAssets.Instance.blueDress;
            case ItemType.Jeans: return ItemAssets.Instance.jeans;
            case ItemType.Hat: return ItemAssets.Instance.hat;
        }
    }
}
