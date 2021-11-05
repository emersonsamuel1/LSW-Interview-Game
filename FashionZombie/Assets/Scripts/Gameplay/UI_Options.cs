using UnityEngine;
using UnityEngine.UI;

public class UI_Options : MonoBehaviour
{
    [SerializeField]private GameObject buyStore;
    [SerializeField]private GameObject sellStore;

    private void Awake() {
        buyStore.SetActive(false);
        sellStore.SetActive(false);
    }
    public void OnBuyClick()
    {
        buyStore.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void OnSellClick()
    {
        sellStore.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
