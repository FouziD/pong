using UnityEngine;

public class inputPaddle : MonoBehaviour
{
    public float speed = 3f;
    public string leftOrRight;

    // functions that handles movement and has varbials for up and down
    void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up))
        { transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        else if (Input.GetKey(down))
        {
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
