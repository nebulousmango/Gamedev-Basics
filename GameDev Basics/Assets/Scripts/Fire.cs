using UnityEngine.SceneManagement;
using UnityEngine;

public class Fire : MonoBehaviour
{
    //Declaring scene variable.
    Scene gameScene;

    //Start runs on the first frame.
    private void Start()
     {
        //Sets gameScene to current scene.
        gameScene = SceneManager.GetActiveScene();
     }

    //Function for if player passes through this object.
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Checks if player object contains the PlayerController script.
        if (other.GetComponent<PlayerController>() == true)
        {
            //Loads current scene.
            SceneManager.LoadScene(gameScene.buildIndex);
        }
    }

}
