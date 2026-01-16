using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float turnSpeed;
    private float horizontalInput;
    private float verticalSpeed;
    private Rigidbody rb;




    private void Awake()
    {
        rb = GetComponent <Rigidbody>();
    }
    
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalSpeed = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            ResetPos();
        }

    }

    private void ResetPos()
    {
        transform.position = new Vector3(0, 0, 0);

        transform.rotation = Quaternion.identity;

        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
