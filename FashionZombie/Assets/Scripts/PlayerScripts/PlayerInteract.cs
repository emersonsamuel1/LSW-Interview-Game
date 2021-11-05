using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
[SerializeField]private PlayerInputs playerInputs;
[SerializeField]private float range;
private Vector2 savePosition;

private void Update() {
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
    Gizmos.DrawLine(playerInputs.playerInRange.bodyTransform.position,playerInputs.playerInRange.bodyTransform.position + new Vector3(0,range,0));
}
}
