using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutfitManager : MonoBehaviour
{
    [SerializeField]private Sprite bodySpriteFront,bodySpriteRight,bodySpriteBack;
    [SerializeField]private PlayerInputs playerInputs;

    PlayerAnimationManager playerAnimationManager;

    SpriteRenderer spriteRenderer;

    [SerializeField]internal Item _item;
    [SerializeField]internal Item lastItem;

    private void Awake() {
        spriteRenderer = transform.Find("Body").GetComponent<SpriteRenderer>();
        playerAnimationManager = playerInputs.playerAnimationManager;
    }
    
    public void ChangeItem(Item currentItem)
    {
        CheckLastItem(_item);
        _item = currentItem;
        playerInputs.playerInventory.RemoveFromInventory(_item);
        playerInputs.playerInventory.AddToInventory(lastItem);
    }

    void CheckLastItem(Item _Item)
    {
        lastItem = _item;
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
            case PlayerAnimationManager.playerState.WalkingLeft:
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
            spriteRenderer.sprite = bodySpriteBack;
            break;

        }

        bodySpriteFront = ChangeSpriteFront();
        bodySpriteBack = ChangeSpriteBack();
        bodySpriteRight = ChangeSpriteRight();
    }

    Sprite ChangeSpriteFront()
    {
        return _item.Bodyfront;
    }

    Sprite ChangeSpriteBack()
    {
        return _item.Bodyback;
    }

    Sprite ChangeSpriteRight()
    {
        return _item.Bodyright;
    }
}
