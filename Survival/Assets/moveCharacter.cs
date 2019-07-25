using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharacter : MonoBehaviour
{
    public Vector3 pos;
    void Start()
    {
        pos = transform.position;
    }

    
    void Update()
    {
        bool aKey = Input.GetKey(KeyCode.A);
        bool sKey = Input.GetKey(KeyCode.S);
        bool wKey = Input.GetKey(KeyCode.W);
        bool dKey = Input.GetKey(KeyCode.D);
        transform.position = pos;
    }
}
