using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    private PlayerControls playerControls;
    [SerializeField] internal PlayerMovements playerMovement;
    [SerializeField] internal PlayerInRange playerInRange;
    [SerializeField] internal PlayerInventory playerInventory;
    [SerializeField] internal PlayerTrigger playerTrigger;
    [SerializeField] internal PlayerOutfitManager playerOutfitManager;
    [SerializeField]internal PlayerAnimationManager playerAnimationManager;
    [SerializeField]internal PlayerSoundManager playerSoundManager;
    internal Vector2 direction;
    internal Rigidbody2D rb;
    public bool interactButton;
    public float mouseClick;

    public bool esc;


    public void EnableControlsLand()
    {
        playerControls.Chatting.Disable();
        playerControls.Land.Enable();
    }

    public void DisableControlsLand()
    {
        playerControls.Land.Disable();
        playerControls.Chatting.Enable();
    }

    public void EnableControlsChatting(){
        playerControls.Chatting.Enable();
    }

       public void DisableControlsChatting(){
        playerControls.Chatting.Disable();
    }
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

    private void Start() {
        EnableControlsLand();
    }

    void Inputs()
    {
        direction = playerControls.Land.Walking.ReadValue<Vector2>();

       interactButton = playerControls.Land.Interact.triggered;

        mouseClick = playerControls.Chatting.SkipText.ReadValue<float>();

        esc = playerControls.Land.Pause.triggered;
    }
    

    void FixedUpdate()
    {
        Inputs();
    }
}