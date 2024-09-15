using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Esto solo funcionara antes del primer frame");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning("Esto se funcionara todos los frames");
    }

    private void FixedUpdate()
  {
        Debug.Log("Esto funcionara cada 50 frames");
    }
}
