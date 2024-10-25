using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour 
{

    [SerializeField] float moveSpeed = 10.0f;
    
    // Start is called before the first frame update
    void Start() 
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update() 
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("This is an instruction to the console!");
        Debug.Log("Hello!");
        Debug.Log("Move the player you kov!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }
}