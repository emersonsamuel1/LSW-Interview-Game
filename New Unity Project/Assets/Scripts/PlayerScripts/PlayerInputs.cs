using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    private PlayerControls playerControls;
    [SerializeField] internal PlayerMovements playerMovement;
    [SerializeField] internal PlayerInRange playerInRange;

    internal Vector2 direction;

    internal Rigidbody2D rb;

    public float interactButton;

    void Awake()
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void OnEnable() {
        playerControls.Enable();
    }

    private void OnDisable() {
        playerControls.Disable();
    }

    void Inputs()
    {
        direction = playerControls.Land.Walking.ReadValue<Vector2>();

        interactButton = playerControls.Land.Interact.ReadValue<float>();
    }

    void Update()
    {
        Inputs();
    }
}