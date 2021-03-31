using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePairBehaviour : MonoBehaviour
{
    public void Destroy()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KillPlane"))
            Destroy();
    }
}
