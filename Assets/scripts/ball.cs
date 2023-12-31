using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed;
    public float ySpeed;

    // Start is called before the first frame update
    void Start()
    {    // speed of the ball
        transform.position = new Vector3(Xposition, Yposition, 0);
        xSpeed = 1f;
        ySpeed = 1f;
    }
    private Rigidbody2D _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {  // the ball is moving not om frame rate but actual time so speed is the the same on every device
        Xposition = Xposition + xSpeed * Time.deltaTime;
        Yposition = Yposition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
    }
    


    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
        // it control the speed of the gameobject
    {
        if (collision.gameObject.CompareTag("horizontalWall") == true)
        {
            ySpeed = ySpeed * -1f;
        }

        else if (collision.gameObject.CompareTag("verticaltalWall"))
        {
            xSpeed = xSpeed * -1f;
        }

        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1.1f;
        }
    }
}
