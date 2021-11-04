using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    internal enum playerState
    {
        WalkingLeft,
        WalkingRight,
        WalkingBackwards,
        WalkingFront,
        Interacting,
        Idle,
        SideIdle,
        BackIdle,
        LeftIdle
    }

    [SerializeField]internal PlayerInputs playerInputs;
    [SerializeField]private Animator animator;

    [SerializeField]private SpriteRenderer spriteRenderer;

    const string sideWalking = "SideWalking";
    const string leftWalking = "LeftWalking";
    const string backWalking = "BackWalking";
    const string frontWalking = "FrontWalking" ;
    const string idle = "Idle";
    const string sideIdle = "SideIdle";
    const string leftIdle = "LeftIdle";
    const string backIdle = "BackIdle";
    internal playerState activeState;
    private Vector2 lastPosition;

    private void Awake() {
    animator = GetComponent<Animator>();
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
            ChangeAnimationState(leftWalking);

            break;
            case playerState.WalkingRight:
            ChangeAnimationState(sideWalking);

            break;
            case playerState.WalkingFront:
            ChangeAnimationState(frontWalking);

            break;
            case playerState.WalkingBackwards:
            ChangeAnimationState(backWalking);

            break;
            case playerState.Idle:
            ChangeAnimationState(idle);

            break;
            case playerState.BackIdle:
            ChangeAnimationState(backIdle);
            break;
            case playerState.SideIdle:
            ChangeAnimationState(sideIdle);
            break;
            case playerState.LeftIdle:
            ChangeAnimationState(leftIdle);
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

        }
        else if(current.x < 0 && current.y == 0)
        {
            activeState = playerState.WalkingLeft;

        }
        else if(current.y > 0)
        {
            activeState = playerState.WalkingBackwards;

        }
        else if(current.y < 0)
        {
            activeState = playerState.WalkingFront;

        }
        else if(lastPosition == Vector2.up && current == Vector2.zero)
        {
            activeState = playerState.BackIdle;

        }
        else if(lastPosition == Vector2.down && current == Vector2.zero)
        {
            activeState = playerState.Idle;

        }
        else if(lastPosition == Vector2.right && current == Vector2.zero)
        {
            activeState = playerState.SideIdle;

        }
        else if(lastPosition == Vector2.left && current == Vector2.zero)
        {
            activeState = playerState.LeftIdle;

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

    public void ChangeAnimationState(string stateName)
    {
        animator.Play(stateName);
    }
    
}
