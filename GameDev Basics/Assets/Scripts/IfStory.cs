using UnityEngine;

public class IfStory : MonoBehaviour
{
    public int I_Year;
    string s_DoThis = "Do nothing yet.";

    // Start is called before the first frame update
    void Start()
    {
        if(I_Year==2020)
        {
            s_DoThis = "Start Coronavirus";
            Debug.Log(s_DoThis);
        }
        else
        {
            Debug.Log(s_DoThis);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            s_DoThis = "Make vaccine.";
            Debug.Log(s_DoThis);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            s_DoThis = "Do nothing.";
            Debug.Log(s_DoThis);
        }
    }
}
