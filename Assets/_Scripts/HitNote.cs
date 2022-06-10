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

    public void Update()
    {
        if (HitNote.isReading && NotePanel.active)
        {
            if (Input.GetButtonDown("Fire2"))
            {
                NotePanel.SetActive(false);
                HitNote.isReading = false;
            }
        }
    }
}
