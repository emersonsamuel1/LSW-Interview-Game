using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutfitManager : MonoBehaviour
{
    [SerializeField]private Sprite bodySpriteFront,bodySpriteRight,bodySpriteBack;
    [SerializeField]private PlayerInputs playerInputs;

    PlayerAnimationManager playerAnimationManager;

    SpriteRenderer spriteRenderer;

    [SerializeField]Item item;

    private void Awake() {
        spriteRenderer = transform.Find("Body").GetComponent<SpriteRenderer>();
        playerAnimationManager = playerInputs.playerAnimationManager;
    }
    
    public void ChangeItem(Item currentItem)
    {
        item = currentItem;
    }

    private void Update() {
        switch(playerAnimationManager.activeState)
        {
            case PlayerAnimationManager.playerState.WalkingBackwards:
            spriteRenderer.sprite = bodySpriteBack;
            break;
            case PlayerAnimationManager.playerState.WalkingRight:
            spriteRenderer.sprite = bodySpriteRight;
            break;
            case PlayerAnimationManager.playerState.WalkingFront:
            spriteRenderer.sprite = bodySpriteFront;
            break;
            case PlayerAnimationManager.playerState.Idle:
            spriteRenderer.sprite = bodySpriteFront;
            break;
            case PlayerAnimationManager.playerState.SideIdle:
            spriteRenderer.sprite = bodySpriteRight;
            break;
            case PlayerAnimationManager.playerState.LeftIdle:
            spriteRenderer.sprite = bodySpriteRight;
            break;
            case PlayerAnimationManager.playerState.BackIdle:
            spriteRenderer.sprite = bodySpriteRight;
            break;

        }

        bodySpriteFront = ChangeSpriteFront();
        bodySpriteBack = ChangeSpriteBack();
        bodySpriteRight = ChangeSpriteRight();
    }

    Sprite ChangeSpriteFront()
    {
        return item.Bodyfront;
    }

    Sprite ChangeSpriteBack()
    {
        return item.Bodyback;
    }

    Sprite ChangeSpriteRight()
    {
        return item.Bodyright;
    }
}
