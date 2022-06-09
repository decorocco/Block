using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathHitbox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.ChangeState(GameState.GameOver);
    }
}
