using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiempovida : MonoBehaviour
{
    public float tiempodevida;
    void Start()
    {
        Destroy(gameObject,tiempodevida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
