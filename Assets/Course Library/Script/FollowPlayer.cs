using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 offset = new Vector3(0, 6, -8);
    private Vector3 fpsOffset = new Vector3(0, 4, 3);

    private bool firstPerson = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            SwitchCameraMode();
        }
    }

    private void LateUpdate()
    {
        if (firstPerson)
        {
            transform.position = player.transform.position + fpsOffset;

            transform.rotation = player.transform.rotation;
        }
        else
        {
            transform.position = player.transform.position + offset;

            transform.rotation = Quaternion.Euler(17, 0, 0);

        }
    }

    private void SwitchCameraMode()
    {
        firstPerson = !firstPerson;


        //if (!firstPerson)
        //{
        //    firstPerson = true;
        //}
        //else
        //{
        //    firstPerson = false;
        //}
    }
}
