using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeperMain : MonoBehaviour,IInteractable
{   
    public DialogDisplay dialogDisplay;
    [SerializeField]private PlayerInputs playerInputs;

    private void Awake() {
    playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();
    }
    void Start()
    {
    
    }

    public void Interact()
    {
        playerInputs.DisableControlsLand();
        dialogDisplay.AdvanceConversationOnlyOnce();
    }
    void FixedUpdate()
    {
    }
}
