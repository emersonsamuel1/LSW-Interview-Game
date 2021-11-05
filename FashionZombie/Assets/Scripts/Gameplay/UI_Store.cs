using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Store : MonoBehaviour
{
    public int[] setPrices;

    [SerializeField]Transform[] priceObjects;
    GameController gameController;
    PlayerInputs playerInputs;
    int currentMoney;
    Item getItem;
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
        gameController.AddMoney(i);
    }

    public void ExitButton()
    {
        this.gameObject.SetActive(false);
    }

}

