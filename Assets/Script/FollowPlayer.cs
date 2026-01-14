using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = player.transform.position +  new Vector3(0, 6, -8);
    }
}
