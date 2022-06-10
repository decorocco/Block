using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealGun : MonoBehaviour
{
    [SerializeField] public Camera cam;
    private float range = 20f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !MenuController.GameIsPaused)
        {
            StopGas();
        }
    }

    void StopGas()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            BlockPipe block = hit.transform.GetComponent<BlockPipe>();
            if (block != null)
            {
                block.BlockGas();
            }
        }
    }
}
