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
    public GameObject startUI;

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
                break;
            case GameState.Level1:
                SceneManager.LoadScene("EikinhoOffice");
                break;
            case GameState.Options:
                SceneManager.LoadScene("Options");
                break;
            case GameState.GameOver:
                SceneManager.LoadScene("Options");
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
    Options = 2,
    GameOver = 3
}