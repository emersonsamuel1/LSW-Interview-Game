using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeperMain : MonoBehaviour,IInteractable
{   
    public DialogDisplay dialogDisplay;
    [SerializeField]internal PlayerInRange playerInRange;
    [SerializeField]private float range;
    [SerializeField]private PlayerInputs playerInputs;

    private void Awake() {
    playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();
    }
    void Start()
    {
    
    }

    public void Interact()
    {
        dialogDisplay.AdvanceConversation();
        playerInputs.DisableControlsLand();
    }
    void FixedUpdate()
    {
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position,range);
    }
}

public class CheckArea
{
    public bool CheckAreaPlayer(float distanceFromPlayer,float Range)
    {
        if(Range > distanceFromPlayer)
        {
            return true;
        }
        else return false;
    }
}
