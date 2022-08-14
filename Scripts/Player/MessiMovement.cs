using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessiMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3f;
    private float cameraAxisX = 0f;

    void Start()
    {
        RotatePlayer();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer(Vector3.back);
        }

        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector3.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector3.right);
        }

 void OnCollisionEnter(Collision other) {
    Debug.Log("estoy chocando"+ other.gameObject.name);
}


    }

    private void MovePlayer(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void RotatePlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Quaternion newRotation = Quaternion.Euler(0, cameraAxisX, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime);
    }
}
