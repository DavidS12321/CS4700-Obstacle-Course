using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float waitingTime = 3.0f;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;

    }

    void Update() 
    {
        if (Time.time > waitingTime) 
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
