using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHitboxParticle : MonoBehaviour
{
    public ParticleSystem particleSystem;

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("gas");
        GameManager.Instance.ChangeState(GameState.GameOver);
    }
}
