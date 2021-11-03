using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    [SerializeField]private int money;
    void Start()
    {
        
    }

    void AddMoney(int addedMoney){
        money += addedMoney;
    }

    private void Update() {
    textMeshProUGUI.text = money.ToString();    
    }

    


}
