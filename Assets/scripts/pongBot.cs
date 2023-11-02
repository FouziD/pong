using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBot : MonoBehaviour
{    //vertical and vertical speed
    public float ySpeed = 3f;
    //vertical and vertical position
    private float yPosition = 0;
    // reference gameobject (ball)
    public GameObject ball;

    // Update is called once per frame
    void Update() 
    {   // x position is handeld with the current x position.( transform x position )
        transform.position = new Vector3(transform.position.x, ball.transform.position.y / 3 * 2);
    }

}
