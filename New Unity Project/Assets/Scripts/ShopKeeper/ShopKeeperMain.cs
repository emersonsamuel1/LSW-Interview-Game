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

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        CheckingArea();
    }

    void CheckingArea()
    {
       maximumPlayerDistance = checkDistancePlayer.Distance(transform.position); 

       inRange = checkArea.CheckAreaPlayer(maximumPlayerDistance,range);
    }


    public void Interact()
    {

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
