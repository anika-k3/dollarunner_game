using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

// Created a class for movement for the character
public class movement : MonoBehaviour
{
    // Creates a float for the horizontal movement
    private float horizontal;
    // Creates a float set to the speed of the character's movements
    private float speed = 8f;
    // Creates a float set to the jumping power of the character
    private float jumpingPower = 24f;
    // The player is currently facing right at the beginning of the game, so this is true
    private bool isFacingRight = true;

    //Highscore Class
    [SerializeField] DollarText dollarText;
    // Highscore as an integer
    int dollarCount;

    [SerializeField] TextMeshProUGUI highscoreText;

    // To use the rigidbody component
    [SerializeField] private Rigidbody2D rb;
    // A groundcheck to ensure the player is on the ground
    [SerializeField] private Transform groundCheck;
    // A mask which is used to determine which layer is considered as ground to the player
    [SerializeField] private LayerMask groundLayer;
    // An integer called sceneID, which will be called upon to change scenes
    [SerializeField] private int sceneID;
    // An integer called sceneID2, which will be called upon to change scenes, a different scene than what was chosen in sceneID
    [SerializeField] private int sceneID2;

    
    void Update()
    {
        // Returns the value of the x-axis
        horizontal = Input.GetAxisRaw("Horizontal");

        // If the button allocated as jump is clicked (which is a custom Unity button, the jump button), and the character is on the ground then it will change the vector's positions
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            // rb.velocity represents the rate of change of the rigidbody's position, it is equal to a new vector with the x-axis' position of the rigibody and the jumping power of the character
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        // If the space bar is clicked and the position of the rigidbody's y-axis is greater than 0, then the positions will change
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            // Then there is a new vector that has the x-axis' position and the y-axis' position gets cut by half because the player has already jumped and needds to come back down
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        // Used to flip the player
        Flip();
    }
    private void FixedUpdate()
    {
        // A new vector is created with the x-axis position of the horizontal movement of the player, multiplied by the speed, and the y-axis of the rigidbody's position
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    // When the player is grounded this will be true
    private bool isGrounded()
    {
        // Checks to see if a collider is within a circle and returns the results
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    // Used to flip the player's direction in the x-axis
    private void Flip()
    {
        // 
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    // This code activates when there is a 2D trigger collision that happens between objects
    private void OnTriggerEnter2D(Collider2D collider)
    {
        // If the player collides with a tag called NextLevel, then the scene will change to be the next level
        if (collider.gameObject.CompareTag("NextLevel"))
        {
            Debug.Log("Trigger");
            SceneManager.LoadScene(sceneID);
        }
    }
    // This code activates when there is a 2D Collision within objects
    private void OnCollisionEnter2D(Collision2D collision)
    {

        // If the player collides with a tag called Money, then the money disappears
        if (collision.gameObject.CompareTag("Money"))
        {
            Debug.Log("Collision");
            Destroy(collision.gameObject);

            UpdateHighscoreText();

            dollarCount++;
            dollarText.IncrementDollarCount(dollarCount);
            CheckHighscore();


            void CheckHighscore()
            {
                if (dollarCount > PlayerPrefs.GetInt("Highscore", 0))
                {
                    PlayerPrefs.SetInt("Highscore", dollarCount);
                }
            }

            void UpdateHighscoreText()
            {
                highscoreText.text = $"Highscore:{PlayerPrefs.GetInt("Highscore", 0)}";
            }
            // Sends the highscore to the console
            Debug.Log(dollarCount);


            //PlayerPrefs.SetInt("Highscore", dollarCount);
            //PlayerPrefs.GetInt("Highscore");
        }

        

        // If the player collides with an object called TriggersDeath, then the scene will change to the death scene
        if (collision.gameObject.CompareTag("TriggersDeath"))
        {
            Debug.Log("Collision");
            SceneManager.LoadScene(sceneID2);
        }
    }
}
