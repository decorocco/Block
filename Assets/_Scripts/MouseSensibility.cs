using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseSensibility : MonoBehaviour
{
    public Slider mainSlider;

    public void SubmitSliderSetting()
    {
        CameraMovement.mouseSensitivity = 200f * mainSlider.value;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
