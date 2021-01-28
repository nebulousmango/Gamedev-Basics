using UnityEngine.SceneManagement;
using UnityEngine;

public class Win : MonoBehaviour
{
    //Adding Unity slot to set scene name to be loaded.
    public string S_SceneName;

    //Function for if player passes through this object.
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Checks if player object contains the PlayerController script.
        if (other.GetComponent<PlayerController>() == true)
        {
            //Loads scene as set in Unity.
            SceneManager.LoadScene(S_SceneName);
        }
    }
}