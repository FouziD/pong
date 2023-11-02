using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class collision : MonoBehaviour
// summary
// variabels
// move in x and y direction
//change course when it collide whit a wall or paddle
// when ball hit a paddle it speeds up
// scorring when ball hits left or right wall
// showing score in a text field
// summary
{ 
    //horizontal and vertical speed
    public float xSpeed = 1f;
    public float ySpeed = 1f;
    // reference to text object (has to be linkt in unity)
    public TMP_Text scoreField;
    // keeping left score and right score
    private int leftScore = 0;
    private int rightScore = 0;
    // if the top score is met it stops the game
    public int topScore = 10;
    

    // function for resets the ball
    private void resetBall(string leftOrRight)
    {
        GetComponent<ball>().Xposition = 0f;
        GetComponent<ball>().Yposition = 0f;
        //displays left and right score in text field
        scoreField.text = leftScore + " - " + rightScore;

        // cheacks argument from the function if left or right is typed in
        if (leftOrRight == "left")
        {
            //ball goes right and up
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
        // cheaks if left or right score value is equel or bigger then top score
        // if it's met it stops and place the ball in the middle
        // show in text field witch player has won.
        if (leftScore >= topScore)
        { // the speed
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

      // if it hit a gameobject with a collider (2d) and it is set to a trigger it does somthing
    private void OnTriggerEnter2D(Collider2D collision)
    {    // if gameobject has a tag that is called "horizontalWall" and it has a collider on it set to trigger
        if (collision.gameObject.CompareTag("horizontalWall"))
        {    
            // flippos direction vertiacal from uo to down of vice versa
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("leftWall"))
        {    // adds 1 to the right score and triggers the rest function whit left argument
            rightScore++;
            resetBall("left");
        }
        else if (collision.gameObject.CompareTag("rightWall"))
        {
            leftScore++;
            resetBall("right");
        }
        else if (collision.gameObject.CompareTag("Player"))
        {  //if it hits a paddle it flips the horizontale direction and increase the speed whit 10%
            xSpeed = xSpeed * -1.1f;
        }
    }
}