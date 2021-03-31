using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlaneBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PipePairBehaviour pipeScript = other.GetComponent<PipePairBehaviour>();
        if (pipeScript)
            pipeScript.Destroy();
    }
}
