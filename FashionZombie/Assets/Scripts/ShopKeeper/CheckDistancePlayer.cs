using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDistancePlayer : MonoBehaviour
{    Transform player;
    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public float Distance(Vector2 thisGameObject)
    {
        float distance = Vector2.Distance(player.position,thisGameObject);
        return distance;
    }
}
