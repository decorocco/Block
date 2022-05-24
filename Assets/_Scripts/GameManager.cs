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
                
                break;
            case GameState.Level1:
                
                break;
            case GameState.Level2:
                
                break;
            case GameState.Level3:
               
                break;
            case GameState.Tutorial:
                
                break;
            case GameState.Sandbox:
                
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
    Tutorial = 4,
    Sandbox = 5
}