using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    PlayerInputs playerInputs;

    [SerializeField]private GameObject pauseMenu;

    private void Awake() {
        playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();
    }

    private void FixedUpdate() {
        if(playerInputs.esc)
        {
            Pause();
        }
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Menu()
    {
        pauseMenu.SetActive(false);
        SceneManager.UnloadSceneAsync("Store");
                Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
