using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInRange : MonoBehaviour
{
    [SerializeField]internal Transform bodyTransform;
    private IInteractable interactable;
    [SerializeField]internal PlayerInputs playerInputs;
    public virtual void CheckingArea(Vector2 facingDirection,float range)
    {
        RaycastHit2D hit = Physics2D.Raycast(bodyTransform.position,facingDirection,range);
        if(hit.collider != null){
            if (hit.collider.GetComponent<IInteractable>() == null)
            {
                return;
            }
            else if(hit.collider.GetComponent<IInteractable>() != null && playerInputs.interactButton)
            {
                interactable = hit.collider.GetComponent<IInteractable>();

                interactable.Interact();
            }
        }
        else
        {
            return;
        }
            


    }
}
