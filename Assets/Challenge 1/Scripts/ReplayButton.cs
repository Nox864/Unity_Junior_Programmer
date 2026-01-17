using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButton : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("MainScene");
        
    }
}
