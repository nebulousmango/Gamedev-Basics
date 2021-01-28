using UnityEngine;

public class CamFollow : MonoBehaviour
{
    //Adding Unity slot to access sphere's Transform component. 
    public Transform tran_Sphere;
    //Declaring float for sphere's x value.
    float f_posX;
    //Declaring float for sphere's y value.
    float f_posY;
    //Declaring Vector3 to store camera's 3 position values.
    Vector3 v3_newPos;
    
    //Update runs on every frame.
    private void Update() 
    {
        //Set float to sphere's x position.
        f_posX = tran_Sphere.position.x;
        //Set float to sphere's y position.
        f_posY = tran_Sphere.position.y;
        //Set Vector's x value to x float value.
        v3_newPos.x = f_posX;
        //Set Vector's y value to y float value.
        v3_newPos.y = f_posY;
        //Set Vector's z value to camera's z position.
        v3_newPos.z = transform.position.z;
        //Set this object position to Vector3 values.
        transform.position = v3_newPos;
    }

}
