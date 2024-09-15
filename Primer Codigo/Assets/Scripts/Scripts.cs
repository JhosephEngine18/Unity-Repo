using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    //int x;

    // Start is called before the first frame update
    void Start()
    {
        //x = 0;
        print("Algo paso");
        Debug.LogWarning("Cuidado");
        Debug.LogError("Noooo");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);

        Debug.Log("Hola desde update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde fixed update cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde Late update");
    }
    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido activado");
    }
    private void OnDisable()
    {
        Debug.Log("El Objeto a sido desactivado");
    }
}
