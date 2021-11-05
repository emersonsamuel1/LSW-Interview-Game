using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AraraInteract : MonoBehaviour,IInteractable
{
    private Animator animator;
    private AudioSource audioSource;

    private void Awake() {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    public void Interact()
    {
        animator.Play("Interacted");
        audioSource.Play();
    }
}
