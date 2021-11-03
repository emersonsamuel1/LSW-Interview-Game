using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
[SerializeField]private PlayerInputs playerInputs;
[SerializeField]private float range;
private Vector2 savePosition;

private void FixedUpdate() {
    CheckInteract();
}
Vector2 CheckDirection()
{
    if(playerInputs.direction != Vector2.zero)
    {
        savePosition = playerInputs.direction;
    }
    return savePosition;
    
}
void CheckInteract()
{
    playerInputs.playerInRange.CheckingArea(CheckDirection(),range);
}

private void OnDrawGizmos() {
    Gizmos.color = Color.green;
    Gizmos.DrawLine(transform.position,transform.position + new Vector3(0,range,0));
}
}
