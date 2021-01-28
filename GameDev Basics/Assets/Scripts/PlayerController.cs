using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Adding Unity slot to access player object's Rigidbody2D component.
    public Rigidbody2D Rigidbody_Player;
    //Adding Unity slot to set player animator.
    public Animator Animator_Player;
    //Adding Unity slot to edit player's speed. 
    public float F_MoveSpeed;
    //Declaring Vector2 for player's jump movement.
    public Vector2 v2_MoveUp = new Vector2(0,350);
    //Declaring boolean for whether player is on a floor or not.
    bool b_TouchingFloor = false;

    // Update is called once per frame
    void Update()
    {
        //Condition for if holding down D and player is on a floor.
        if(Input.GetKey(KeyCode.D) && b_TouchingFloor == true)
        {
            //Declaring Vector2 for moving to the right, with x value as player's movement speed
            //and y value as player's current velocity's y value.
            Vector2 v2_newSpeedRight = new Vector2(F_MoveSpeed, Rigidbody_Player.velocity.y);
            //Setting player's velocity to Vector2 values.
            Rigidbody_Player.velocity = v2_newSpeedRight;
        }
        //Condition for if holding down A and player is on a floor.
        if(Input.GetKey(KeyCode.A) && b_TouchingFloor == true)
        {
            //Declaring Vector2 for moving to the left, with x value as negative of player's movement speed
            //and y value as player's current velocity's y value.
            Vector2 v2_newSpeedLeft = new Vector2(-F_MoveSpeed, Rigidbody_Player.velocity.y);
            //Setting player's velocity to Vector2 values.
            Rigidbody_Player.velocity = v2_newSpeedLeft;
        }
        //Condition for if player is on a floor AND not holding down either A or D.
        if(b_TouchingFloor == true && (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)))
        {
            //Setting player's velocity to 0.
            Rigidbody_Player.velocity = Vector2.zero;
            //Setting player's angular velocity to 0.
            Rigidbody_Player.angularVelocity = 0;
        }
        //Condition for if player clicks spacebar and player is on a floor.
        if(Input.GetKeyDown(KeyCode.Space) && b_TouchingFloor == true)
        {
            //Gives player object upward force.
            Rigidbody_Player.AddForce(v2_MoveUp);
        }
    }
    //Function for when player is touching another object.
    private void OnCollisionEnter2D(Collision2D other)
    {
        //Condition for if object is in the Floors layer.
        if(other.gameObject.layer == 8)
        {
            //Condition for if not holding down A and not holding down D.
            if(!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            {
                //Setting player's velocity to 0.
                Rigidbody_Player.velocity = Vector2.zero;
                //Setting player's angular velocity to 0.
                Rigidbody_Player.angularVelocity = 0;
            }
            //Setting player's Animator component's bool to true.
            Animator_Player.SetBool("B_TouchingFloor", true);
            //Setting bool to true for player touching objects in the Floors layer.
            b_TouchingFloor = true;
        }
    }
    //Function for when player is not touching anything.
    private void OnCollisionExit2D(Collision2D other)
    {
        //Condition for if object is in the Floors layer.
        if (other.gameObject.layer == 8)
        {
            //Setting player's Animator component's bool to false.
            Animator_Player.SetBool("B_TouchingFloor", false);
            //Setting bool to false for player not touching objects in the Floors layer.
            b_TouchingFloor = false;
        }
    }
}
