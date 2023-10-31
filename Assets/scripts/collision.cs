using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class collision : MonoBehaviour
{

    public float xSpeed = 1f;
    public float ySpeed = 1f;
    public TMP_Text scoreField;
    private int leftScore = 0;
    private int rightScore = 0;
    public int topScore = 10;
    

    private void resetBall(string leftOrRight)
    {
        GetComponent<ball>().Xposition = 0f;
        GetComponent<ball>().Yposition = 0f;
        scoreField.text = leftScore + " - " + rightScore;
        if (leftOrRight == "left")
        {
            xSpeed = 0f;
            ySpeed = 0f;
        }
        else if (leftOrRight == "right")
        {
            xSpeed = 0f;
            ySpeed = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {

        
        if (leftScore >= topScore)
        {
            scoreField.text = "Left Player has won!";
            xSpeed = 0;
            ySpeed = 0;
        }
        else if (rightScore >= topScore)
        {
            scoreField.text = "Right Player has won!";
            xSpeed = 0;
            ySpeed = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            ySpeed = ySpeed * -1f;

        }
        else if (collision.gameObject.CompareTag("leftWall"))
        {
            rightScore++;
            resetBall("left");
        }
        else if (collision.gameObject.CompareTag("rightWall"))
        {
            leftScore++;
            resetBall("right");
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1.1f;
        }
    }
}