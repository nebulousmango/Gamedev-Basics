using UnityEngine;
public class IfTextStory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The sun is beginning to set.");
        Debug.Log("Press 1 to look around.");
        Debug.Log("Press 2 to sit down.");
        Debug.Log("Press 3 to begin walking.");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("You look around and decide to start a fire for warmth.");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("You begin to doze in the evening breeze.");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("You look for a stick to cut your way through the grass.");
        }
    }
}
