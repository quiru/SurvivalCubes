using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFps : MonoBehaviour
{
    public float speed = 0.1f; // para darle una velocidad al movimiento
    float mouseX; // para capturar la entrada del mouse

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X"); // va agregando numeros segun el movimiento del mouse en x
        transform.eulerAngles = new Vector3(0, mouseX, 0); // mueve la camara segun el vaor que alla en mouseX


        if (Input.GetKey(KeyCode.W)) //si se presiona la tecla w
        {
            transform.position += transform.forward * speed; //se mueve hacia adelante
        }
        if (Input.GetKey(KeyCode.S)) //si se presiona la tecla s
        {
            transform.position -= transform.forward * speed; //se mueve hacia atras
        }
        if (Input.GetKey(KeyCode.A)) // si se presiona la tecla a
        {
            transform.position -= transform.right * speed; // se mueve a la izquierda
        }
        if (Input.GetKey(KeyCode.D)) // si se presiona la tecla d
        {
            transform.position += transform.right * speed; // se mueve hacia la derecha
        }
    }
}
