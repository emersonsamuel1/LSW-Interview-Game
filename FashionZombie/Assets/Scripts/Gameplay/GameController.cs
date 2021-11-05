using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public int money;
    void Start()
    {
        
    }

    public void AddMoney(int addedMoney){
        money += addedMoney;
    }

    public void TakeMoney(int takenMoney)
    {
        money -= takenMoney;
    }

    private void Update() {
    textMeshProUGUI.text = money.ToString();    
    }

    


}
