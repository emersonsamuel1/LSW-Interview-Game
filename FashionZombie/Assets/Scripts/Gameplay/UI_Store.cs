using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Store : MonoBehaviour
{
    GameController gameController;
    PlayerInputs playerInputs;
    int currentMoney;
    Item getItem;
    int moneyAdded;
    private void Awake() {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();
    }

    private void FixedUpdate() {

    }

    public void GetItem(Item i)
    {
        getItem = i;
    }
    public void OnBought(int i)
    {
        currentMoney = i;
        if(gameController.money >= i && playerInputs.playerInventory.items.Count < 4){
        gameController.TakeMoney(i);
        playerInputs.playerInventory.AddToInventory(getItem);
        }
    }

    public void OnSold(int i)
    {
        moneyAdded = i;
    }

    public void GetSellItemInventory(Item i)
    {
        
        if(playerInputs.playerInventory.items.Find(item => item == i))
        {
            gameController.AddMoney(moneyAdded);
           playerInputs.playerInventory.RemoveFromInventory(playerInputs.playerInventory.items.Find(Item => Item == i));
           playerInputs.playerInventory.onItemChangedCallback.Invoke();
        }
    }

    public void ExitButton()
    {
        playerInputs.EnableControlsLand();
        this.gameObject.SetActive(false);
    }

}

