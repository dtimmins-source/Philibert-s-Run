using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float invokeDelay = 2f;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            Invoke("ReloadScene", invokeDelay);
        }      
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
