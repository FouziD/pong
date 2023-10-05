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
    {
        transform.position = new Vector3(Xposition,Yposition,0);
        xSpeed = 1f;
        ySpeed = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time. deltaTime;
        transform.position = new Vector3(Xposition,Yposition,0);


        
}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontalWall")== true) 
        {
           
            ySpeed = ySpeed * -1f;
            Debug.Log("auw");
        }

        else if (collision.gameObject.CompareTag("verticaltalWall"))
        {
            
            xSpeed = xSpeed * -1f;
            Debug.Log("no");
        }

        
    }
}
