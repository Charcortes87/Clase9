using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encogedor : MonoBehaviour


{
        public Vector3 tamañochico = new Vector3(0.5f, 0.5f, 0.5f);
    public Vector3 tamañonormal = new Vector3(1f, 1f, 1f);
    public bool cambiodetamaño = true;

    private void Start()
    {
    
    }
    private void OnTriggerEnter(Collider other)
    {


if (cambiodetamaño == true)
        {
            Debug.Log("Portal de Reduccion" + other.gameObject.name);

            other.transform.localScale = tamañochico;



        }
        if (cambiodetamaño == false)
        {
            Debug.Log("Portal de Amplificacion" + other.gameObject.name);

            other.transform.localScale = tamañonormal;
         }
}
}
