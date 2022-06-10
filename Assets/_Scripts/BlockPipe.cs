using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPipe : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public Material blockedMaterial;
    Renderer[] allChildRenderers;
    public Material[] allMaterials;

    public void BlockGas()
    {
        allChildRenderers = GetComponentsInChildren<Renderer>();
        for (int i = 1; i < allChildRenderers.Length; i++)
        {
            allChildRenderers[i].material = blockedMaterial;      
        }
        particleSystem.Stop();
        Debug.Log("GAS");
    }
}
