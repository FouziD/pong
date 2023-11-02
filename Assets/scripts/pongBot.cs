using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBot : MonoBehaviour
{    //horizontal and vertical speed
    public float ySpeed = 3f;
    //horizontal and vertical position
    private float yPosition = 0;
    // reference gameobject (ball)
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() 
    {   // it assigning a new valeu to the postion property of the transform component.
        transform.position = new Vector3(transform.position.x, ball.transform.position.y / 3 * 2);
    }

}
