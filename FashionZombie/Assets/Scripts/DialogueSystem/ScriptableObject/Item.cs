using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item",menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name =  "New Item";
    public Sprite icon = null;

    public GameObject mySelf;

    public Sprite Bodyfront,Bodyright,Bodyback;
    public virtual void Use()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>().playerOutfitManager.ChangeItem(this);
        GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>().PlaySound(1);
    }
}
