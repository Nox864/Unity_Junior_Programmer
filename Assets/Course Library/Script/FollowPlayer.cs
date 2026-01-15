using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 offset = new Vector3(0, 6, -8);
    void Start()
    {
        
    }

    
    void Update()
    {
    }

    private void LateUpdate()
    {
        //offset the camera behind the player. 
        transform.position = player.transform.position + offset;     
    }
}
