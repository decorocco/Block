using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    public Slider musicSlider;

    public void SubmitSliderSetting()
    {
        Debug.Log(musicSlider.value);
    }
}
