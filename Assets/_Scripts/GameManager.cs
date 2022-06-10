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
    public static int level = 1;

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
                level = 1;
                cubos = 200;
                break;
            case GameState.Level1:
                SceneManager.LoadScene("Level1");
                break;
            case GameState.Level2:
                SceneManager.LoadScene("Level2");
                break;
            case GameState.Level3:
                SceneManager.LoadScene("Level3");
                break;
            case GameState.Options:
                SceneManager.LoadScene("Options");
                break;
            case GameState.GameOver:
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("GameOver");
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
    Level3 = 3,
    Options = 4,
    GameOver = 5
}