using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField]AudioManager audioManager;
    public TextMeshProUGUI textMeshProUGUI;
    public int money;
    private void Awake() {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    public void AddMoney(int addedMoney){
        audioManager.PlaySellingSound();
        money += addedMoney;
    }

    public void TakeMoney(int takenMoney)
    {
        audioManager.PlayBuyingSound();
        money -= takenMoney;
    }

    private void Update() {
    textMeshProUGUI.text = money.ToString();    
    }

    


}
