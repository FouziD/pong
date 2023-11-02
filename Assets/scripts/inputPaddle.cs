using UnityEngine;


public class inputPaddle : MonoBehaviour
{   // handeling the speed of the paddles
    public float speed = 3f;
    // cheaking if it's the right or left paddle
    // has to be changed in unity
    public string leftOrRight;
  

    // functions that handles movement and has varbials for up and down
    void setKeyAndMovement(KeyCode up, KeyCode down)
    {   // when the up key is pressed and hold and the current position is smaller or equal then 3.6f 
        if (Input.GetKey(up) && transform.position.y <=3.6)
        {   // translate works with a new vector3 and it's changing with a vector3.up with speed and time.deltatime 
            transform.Translate(Vector3.up * speed * Time.deltaTime); 
        }

        // when the down key is pressed and hold and the current position is smaller or equal then 3.6f 
        else if (Input.GetKey(down) && transform.position.y >= -3.6)
        {  // translate works with a new vector3 and it's changing with a vector3.down with speed and time.deltatime 
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
    // Update is called once per frame
    void Update()
    { // change within Unity if it's left or right paddle

        if (leftOrRight == "left")
        {
            setKeyAndMovement(KeyCode.W, KeyCode.S);
        }

        else if (leftOrRight == "right")
        {
            setKeyAndMovement(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
