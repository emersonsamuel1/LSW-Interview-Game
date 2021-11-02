using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCanvas : MonoBehaviour,IOpenCanvas
{
    [SerializeField]GameObject store; 
    bool isActive = false;
    public void IOpenCanvas()
    {

        isActive = !isActive;
        store.SetActive(isActive);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
