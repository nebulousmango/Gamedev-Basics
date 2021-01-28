using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    //Adding Unity slot to access platform's Rigidbody2D component.
    public Rigidbody2D Rigidbody2D;
    //Adding Unity slot to edit platform's speed per distance.
    public float F_SpeedPerUnitOfDistance = 1;
    //Adding Unity slot to edit platform's X speed.
    float F_SpeedX = 1;
    //Adding Unity slot to edit platform's Y speed. 
    float F_SpeedY = 1;
    //Adding Unity slot to set platform's final X position.
    public float F_FinalPositionX;
    //Adding Unity slot to set platform's final Y position.
    public float F_FinalPositionY;
    //Declaring float for platform's starting Y position. 
    float f_InitialPositionY;
    //Declaring bool for whether platform is moving up or not.
    bool b_MovingUp;
    //Declaring float for platform's starting X position.
    float f_InitialPositionX;
    //Declaring bool for whether platform is moving right or not.
    bool b_MovingRight;
    //Declaring float for distance to be travelled along X.
    float f_differenceX;
    //Declaring float for distance to be travelled along Y.
    float f_differenceY;


    //Start runs on the first frame.
    private void Start()
    {
        //Setting float value to the platform's starting X position.
        f_InitialPositionX = transform.position.x;
        //Setting float value to the platform's starting Y position.
        f_InitialPositionY = transform.position.y;

        //Setting float value to the difference between final and initial X positions.
        f_differenceX = F_FinalPositionX - f_InitialPositionX;
        //Setting float value to the difference between final and initial Y positions. 
        f_differenceY = F_FinalPositionY - f_InitialPositionY;

        //Setting platform's X speed.
        F_SpeedX = f_differenceX * F_SpeedPerUnitOfDistance;
        //Setting platform's Y speed.
        F_SpeedY = f_differenceY * F_SpeedPerUnitOfDistance;

        F_SpeedX = Mathf.Abs(F_SpeedX);
        F_SpeedY = Mathf.Abs(F_SpeedY);

    }
    // Update is called once per frame
    void Update()
    {
        //Calling function for platform moving up and down.
        MoveOnY();
        //Calling function for platform moving left and right.
        MoveOnX();
    }
    //Function for platform moving up and down.
    void MoveOnY()
    {
        //Condition for if platform is moving up.
        if (b_MovingUp == true)
        {
            //Condition for if platform's Y position is less than the final Y position.
            if (transform.position.y <= F_FinalPositionY)
            {
                //Declaring Vector2 to store platform's upward movement.
                Vector2 v2_newSpeedUp = new Vector2(Rigidbody2D.velocity.x, F_SpeedY);
                //Setting platform's velocity to Vector2 values.
                Rigidbody2D.velocity = v2_newSpeedUp;
            }
            else
            {
                //Setting bool to false when platform reaches final position.
                b_MovingUp = false;
            }
        }
        //Condition for if platform is not moving up, to send it back down.
        if (b_MovingUp == false)
        {
            //Condition for if platform's Y position is greater than its starting position.
            if (transform.position.y >= f_InitialPositionY)
            {
                //Declaring Vector2 to store platform's downward movemeent.
                Vector2 v2_newSpeedDown = new Vector2(Rigidbody2D.velocity.x, -F_SpeedY);
                //Setting platform's velocity to Vector2 values.
                Rigidbody2D.velocity = v2_newSpeedDown;
            }
            else
            {
                //Setting bool to true when platform reaches starting position.
                b_MovingUp = true;
            }
        }
    }
    //Function for platform moving left and right.
    void MoveOnX()
    {
        //Condition for if platform is moving to the right.
        if (b_MovingRight == true)
        {
            //Condition for if platform's X position is less than the final X position.
            if (transform.position.x <= F_FinalPositionX)
            {
                //Declaring Vector2 to store platform's rightward movement.
                Vector2 v2_speedRight = new Vector2(F_SpeedX, Rigidbody2D.velocity.y);
                //Setting platform's velocity to Vector2 values.
                Rigidbody2D.velocity = v2_speedRight;
            }
            else
            {
                //Setting bool to false when platform reaches final position.
                b_MovingRight = false;
            }
        }
        //Condition for if platform is moving to the left.
        if (b_MovingRight == false)
        {
            //Condition for if platform's X position is greater than the starting point.
            if (transform.position.x >= f_InitialPositionX)
            {
                //Declaring Vector2 to store platform's leftward movement.
                Vector2 v2_speedLeft = new Vector2(-F_SpeedX, Rigidbody2D.velocity.y);
                //Setting platform's velocity to Vector2 values.
                Rigidbody2D.velocity = v2_speedLeft;
            }
            else
            {
                //Setting bool to true when platform reaches starting point.
                b_MovingRight = true;
            }
        }
    }
}
