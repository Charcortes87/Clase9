using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walldestinations : MonoBehaviour
{

    [SerializeField]
    [Range(2, 10)]
    public float cooldown;

   



 

    private float timeInPortal = 0;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTRANDO EN TRIGGER CON ->" + other.gameObject.name);
        timeInPortal = 0;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("SALIENDO DEL TRIGGER ->" + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
                timeInPortal += Time.deltaTime;
             if (timeInPortal >= cooldown)
        {
                    Debug.Log("Donde Estoy" + other.transform.position);
                    other.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(2f,10f), Random.Range(-10.0f, 10.0f));
        }

    }
}