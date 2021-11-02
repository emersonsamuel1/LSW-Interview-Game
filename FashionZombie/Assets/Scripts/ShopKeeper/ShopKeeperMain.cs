using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeperMain : MonoBehaviour,IInteractable
{
    [SerializeField]internal CheckDistancePlayer checkDistancePlayer;
    [SerializeField]private float maximumPlayerDistance;
    private CheckArea checkArea = new CheckArea();
    [SerializeField]private float range;
    [SerializeField]private bool inRange;
    [SerializeField]private PlayerInputs playerInputs;
    [SerializeField]internal PlayerInRange playerInRange;

    private void Awake() {
    playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();
    playerInRange = GetComponent<PlayerInRange>();
    }
    void Start()
    {
        
    }

    public void Interact()
    {
        Debug.Log("interagiu");
    }

    void FixedUpdate()
    {
        playerInRange.CheckingArea(range);
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position,range);
    }
}

public class CheckArea
{
    public bool CheckAreaPlayer(float distanceFromPlayer,float Range)
    {
        if(Range > distanceFromPlayer)
        {
            return true;
        }
        else return false;
    }
}
