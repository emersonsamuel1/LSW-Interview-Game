using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    [SerializeField]internal PlayerInputs playerInputs;

    private void OnTriggerStay2D(Collider2D other) {
        IPickable ipickable = other.GetComponent<IPickable>();
        if(ipickable != null && playerInputs.interactButton)
        {
            ipickable.Picked();
        }
    }
}
