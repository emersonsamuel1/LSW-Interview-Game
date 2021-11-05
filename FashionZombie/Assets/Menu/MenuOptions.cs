using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{
    public GameObject buttons;
    public GameObject loading;
    public void OnPLay()
    {
        buttons.SetActive(false);
        loading.SetActive(true);
        SceneManager.LoadScene("Store");
    }

    public void OnEnter(GameObject gameObject)
    {
        gameObject.SetActive(true);
        buttons.SetActive(false);
    }

    public void OnLeave(GameObject gameObject)
    {
        gameObject.SetActive(false);
        buttons.SetActive(true);
    }

    public void OnExit()
    {
        Application.Quit();
    }
}
