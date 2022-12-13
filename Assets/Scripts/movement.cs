using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    // 
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private int sceneID;
    [SerializeField] private int sceneID2;
    [SerializeField] private int highscore;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool isGrounded()
    {
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
            highscore += 1;
        }
        // Sends the highscore to the console
        Debug.Log(highscore);

        // If the player collides with an object called TriggersDeath, then the scene will change to the death scene
        if (collision.gameObject.CompareTag("TriggersDeath"))
        {
            Debug.Log("Collision");
            SceneManager.LoadScene(sceneID2);
        }
    }
}
