using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CubeHUD : MonoBehaviour
{
    public Text textComp;

    void Update()
    {
        textComp.text = $"x {GameManager.cubos}";
    }
}
