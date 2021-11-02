using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInRange : MonoBehaviour
{
    PlayerInputs playerInputs;
    IInteractable interactable;
    private void Awake() {
        playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();
        interactable = GetComponent<IInteractable>();
    }
    public virtual void CheckingArea(float range)
    {

       CheckDistancePlayer checkDistancePlayer = GetComponent<CheckDistancePlayer>();
       CheckArea checkArea = new CheckArea();

       float _distance = checkDistancePlayer.Distance(transform.position); 

       bool inRange = checkArea.CheckAreaPlayer(_distance,range);
       
       if(playerInputs.interactButton > 0 && inRange)
       {
           interactable.Interact();
       }
    }
}
