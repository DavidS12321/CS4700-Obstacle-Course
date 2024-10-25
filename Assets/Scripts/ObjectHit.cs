using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer renderer;
    [SerializeField] private Material collisionMaterial;

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            renderer = GetComponent<MeshRenderer>();
            renderer.material = collisionMaterial;

            gameObject.tag = "Hit";
        }

    }
}