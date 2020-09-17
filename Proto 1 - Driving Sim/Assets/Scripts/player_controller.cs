using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    // Access Modifier Type Name Operator Value
    private int speed = 15;
    private float turnSpeed;
    
    public float horizontalInput;
    public float forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        //move the vehicle forward based on forwardInput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //rotates vehicle left and right based on horizontalInput
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
