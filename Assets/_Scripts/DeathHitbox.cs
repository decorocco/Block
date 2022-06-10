using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathHitbox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.lifes < 2) {
        SceneManager.LoadScene("GameOver");

        } else{
            GameManager.lifes --;
            SceneManager.LoadScene("EikinhoOffice");
        }
    
    }


}
