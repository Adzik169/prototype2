using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pause;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void GoToMenu()
    {
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;
    }
    public void ResumeGame()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }
}
