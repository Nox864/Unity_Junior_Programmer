using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;

    [SerializeField] private float propellerSpeed;
    [SerializeField] private GameObject propeller;

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        // tilt the plane right/left based on right/left arrow keys
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime * horizontalInput);

        // Rotate the Propeller 
        propeller.transform.Rotate(Vector3.back * Time.deltaTime * propellerSpeed);

        
    }

    
}
