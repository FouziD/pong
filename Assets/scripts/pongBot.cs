using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBot : MonoBehaviour
{
    public float ySpeed = 3f;
    private float yPosition = 0;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, ball.transform.position.y / 3 * 2);
    }
        //transform.position = new Vector3(transform.position.x, ball.transform.position.y/ ySpeed, transform.position.z);
}
