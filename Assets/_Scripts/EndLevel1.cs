using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.level == 1)
        {
            GameManager.level = 2;
            SceneManager.LoadScene("Level2");
        }
        else if (GameManager.level == 2)
        {
            GameManager.level = 3;
            SceneManager.LoadScene("Level3");
        }
        else if (GameManager.level == 3)
        {
            GameManager.level = 1;
            SceneManager.LoadScene("EndGame");
        }
        
    }
}
