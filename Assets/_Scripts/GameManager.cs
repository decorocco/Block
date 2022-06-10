using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState GameState;
    public static int cubos = 200;
    public static int lifes = 3;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        //ChangeState(GameState.TitleMenu);
    }

    public void ChangeState(GameState newState)
    {
        GameState = newState;
        switch (newState)
        {
            case GameState.TitleMenu:
                SceneManager.LoadScene("TitleMenu");
                lifes = 3;
                break;
            case GameState.Level1:
                SceneManager.LoadScene("Office");
                break;
            case GameState.Level2:
                SceneManager.LoadScene("Office");
                break;
            case GameState.Options:
                SceneManager.LoadScene("Options");
                break;
            case GameState.GameOver:
                SceneManager.LoadScene("GameOver");
                Cursor.lockState = CursorLockMode.None;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
    }
}

public enum GameState
{
    TitleMenu = 0,
    Level1 = 1,
    Level2 = 2,
    Options = 3,
    GameOver = 4
}