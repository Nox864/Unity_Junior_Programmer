using UnityEngine;

public class OnComingVehicleController : MonoBehaviour
{
    [SerializeField] private float speed;

    
    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
