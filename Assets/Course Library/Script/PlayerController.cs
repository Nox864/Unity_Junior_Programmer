using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float turnSpeed;
    private float horizontalInput;
    private float verticalSpeed;




    private void Awake()
    {
        
    }
    
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalSpeed = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);


    }
}
