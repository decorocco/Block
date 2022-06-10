using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUi;
    public GameObject optionMenuUi;
    public static bool GameIsStarting = true;
    public static bool LoadMenu = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUi.SetActive(false);
        optionMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void OnClick()
    {
        GameManager.Instance.ChangeState(GameState.Level1);
        Resume();
    }

    public void OnClickOptionsInGame()
    {
        pauseMenuUi.SetActive(false);
        optionMenuUi.SetActive(true);
    }

    public void OnClickReturn()
    {
        pauseMenuUi.SetActive(true);
        optionMenuUi.SetActive(false);
    }

    public void OnClickOptions()
    {
        GameManager.Instance.ChangeState(GameState.Options);
    }

    public void OnClickMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        //pauseMenuUi.SetActive(false);
        GameManager.Instance.ChangeState(GameState.TitleMenu);
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }
}
