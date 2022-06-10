using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeartHUD : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textComp;

    void Update()
    {
        textComp.text = $"{GameManager.lifes} x";
    }
}
