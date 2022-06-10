using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathHitboxParticle : MonoBehaviour
{
    public ParticleSystem particleSystem;

    private void OnParticleCollision(GameObject other)
    {
        if (GameManager.lifes < 2) {
            SceneManager.LoadScene("GameOver");
        } 
        else{
            GameManager.lifes --;
            if (GameManager.level == 1)
            {
                SceneManager.LoadScene("Level1");
            }
            else if (GameManager.level == 2)
            {
                SceneManager.LoadScene("Level2");
            }
            else if (GameManager.level == 3)
            {
                SceneManager.LoadScene("Level3");
            }
        }
    }
}
