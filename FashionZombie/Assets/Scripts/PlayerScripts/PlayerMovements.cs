using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField]internal PlayerInputs playerInputs;
    [SerializeField]private float speedPlayer;
    private void FixedUpdate() {
        Walking();
    }

    void Walking()
    {
        if(playerInputs.direction != Vector2.zero)
        {
            playerInputs.rb.velocity = playerInputs.direction * speedPlayer;
        }
        
    }
}
