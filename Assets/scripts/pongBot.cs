using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBot : MonoBehaviour
{
    public float ySpeed = 3f;
    public float yPosition = 0f;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //yPosition = yPosition + ySpeed * Time.deltaTime;
        //transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
        //if (yPosition >= 4f)
        //{
        //    ySpeed = ySpeed * -1f;
        //}
        //else if (yPosition <= -4f)
        //{
        //    ySpeed = ySpeed * -1f;
        //}
        transform.position = new Vector3(transform.position.x, ball.transform.position.y, transform.position.z);
    }
}
