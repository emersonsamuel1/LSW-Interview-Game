using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInRange : MonoBehaviour
{
    [SerializeField]internal PlayerInputs playerInputs;
    public bool inRange;
    void Update()
    {
        if(playerInputs.interactButton > 0)
        {
            print("issoae");
        }
    }
}
