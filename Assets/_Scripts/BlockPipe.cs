using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPipe : MonoBehaviour
{
    public ParticleSystem particleSystem;

    public void BlockGas()
    {
        particleSystem.Stop();
        Debug.Log("GAS");
    }
}
