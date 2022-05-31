using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGun : MonoBehaviour
{
    [SerializeField] public Camera cam;
    private float range = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !MenuController.GameIsPaused)
        {
            OpenNote();
        }
    }

    void OpenNote()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            HitNote hitNote = hit.transform.GetComponent<HitNote>();
            if (hitNote != null)
            {
                Vector3 hitLocation = hit.point;
                hitNote.OpenNote();
            }
        }
    }

}
