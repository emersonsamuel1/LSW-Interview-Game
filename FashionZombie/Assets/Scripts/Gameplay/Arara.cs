using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arara : MonoBehaviour,IInteractable
{
    [SerializeField]AudioSource audioSource;
    [SerializeField]internal PlayerInRange playerInRange;
    [SerializeField]private PlayerInputs playerInputs;

    private void Awake() {
    playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();
    }
    public void Interact()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
