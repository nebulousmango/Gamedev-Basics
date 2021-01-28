using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //Adding Unity slot to set scene name to be loaded.
    public string S_LevelOne;

    //Function for loading levels.
    public void LoadLevel()
    {
        //Loads level one.
        SceneManager.LoadScene(S_LevelOne);
    }
    
    //Function for quitting game.
    public void QuitGame()
    {
        //Closes application.
        Application.Quit();
    }

}
