using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    enum playerState
    {
        WalkingLeft,
        WalkingRight,
        WalkingBackwards,
        WalkingFront,
        Interacting,
        Idle,
        SideIdle,
        BackIdle
    }

    [SerializeField]internal PlayerInputs playerInputs;
    [SerializeField]private Animator animator;

    [SerializeField]private SpriteRenderer spriteRenderer;

    const string sideWalking = "SideWalking";
    const string backWalking = "BackWalking";
    const string frontWalking = "FrontWalking" ;
    const string idle = "idle";
    const string sideIdle = "sideIdle";
    const string backIdle = "backIdle";
    playerState activeState;

    private Vector2 lastPosition;

    private void Awake() {
    animator = GetComponent<Animator>();   
    spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    private void Update() 
    {
        StatesSwitch();
        
    }

    private void Start() {
        activeState = playerState.Idle;
    }

    private void StatesSwitch()
    {
        CheckingStates();
           switch(activeState)
        {
            case playerState.WalkingLeft:
            ChangeAnimationState(sideWalking);
            spriteRenderer.flipX = true;
            break;
            case playerState.WalkingRight:
            ChangeAnimationState(sideWalking);
            spriteRenderer.flipX = false;
            break;
            case playerState.WalkingFront:
            ChangeAnimationState(frontWalking);
            spriteRenderer.flipX = false;
            break;
            case playerState.WalkingBackwards:
            ChangeAnimationState(backWalking);
            spriteRenderer.flipX = false;
            break;
            case playerState.Idle:
            ChangeAnimationState(idle);
            spriteRenderer.flipX = false;
            break;
            case playerState.BackIdle:
            ChangeAnimationState(backIdle);
            break;
            case playerState.SideIdle:
            ChangeAnimationState(sideIdle);
            break;
            default:
            break;
        } 
    }

    private void CheckingStates()
    {
        Vector2 current = playerInputs.direction;
        if(current != Vector2.zero) lastPosition = current;

        if(current.x > 0 && current.y == 0)
        {
            activeState = playerState.WalkingRight;
            spriteRenderer.flipX = false;
        }
        else if(current.x < 0 && current.y == 0)
        {
            activeState = playerState.WalkingLeft;
            spriteRenderer.flipX = true;
        }
        else if(current.y > 0)
        {
            activeState = playerState.WalkingBackwards;
            spriteRenderer.flipX = false;
        }
        else if(current.y < 0)
        {
            activeState = playerState.WalkingFront;
            spriteRenderer.flipX = false;
        }
        else if(lastPosition == Vector2.up && current == Vector2.zero)
        {
            activeState = playerState.BackIdle;
            spriteRenderer.flipX = false;
        }
        else if(lastPosition == Vector2.down && current == Vector2.zero)
        {
            activeState = playerState.Idle;
            spriteRenderer.flipX = false;
        }
        else if(lastPosition == Vector2.right && current == Vector2.zero)
        {
            activeState = playerState.SideIdle;
            spriteRenderer.flipX = false;
        }
        else if(lastPosition == Vector2.left && current == Vector2.zero)
        {
            activeState = playerState.SideIdle;
            spriteRenderer.flipX = true;
        }
        else if((lastPosition.x > 0 && lastPosition.y > 0) || (lastPosition.x < 0 && lastPosition.y >0) && current == Vector2.zero)
        {
            activeState = playerState.BackIdle;
        }
        else if((lastPosition.x > 0 && lastPosition.y < 0) || (lastPosition.x < 0 && lastPosition.y < 0)  && current == Vector2.zero)
        {
            activeState = playerState.Idle;
        }
    }

    private void ChangeAnimationState(string stateName)
    {
        animator.Play(stateName);
    }
    
}
