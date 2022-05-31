using System.Collections;
using UnityEngine;

public class HitNote : MonoBehaviour
{
    public GameObject NotePanel;
    public static bool isReading;

    public void OpenNote()
    {
        if (isReading == false)
        {
            NotePanel.SetActive(true);
            isReading = true;
        }
    }
}
