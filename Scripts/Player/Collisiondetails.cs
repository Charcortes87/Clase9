using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiondetails : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("estoy chocando" + other.gameObject.name);

       

    }
     private void OnTriggerEnter(Collider other)
        {
            Encogedor encogedor = other.GetComponent<Encogedor>();
            if (encogedor != null)
            {
                Debug.Log("tiene el portal");
            }
            else 
            {
                Debug.Log("zafaste del portal");
            }
        }
}
