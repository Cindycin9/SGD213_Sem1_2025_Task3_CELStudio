using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float jumpingPower = 16f;
    //private bool isFacingRight = true;

    private PlayerMovement playerMovement;

    private Rigidbody2D rb;

    //[SerializedField] private Transform groundCheck;
    //[SerializedField] private LayerMask groundLayer;



    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }
  


    private void Update()
    {
        // read our horizontal input axis
        float horizontalInput = Input.GetAxis("Horizontal");

        // if movement input is not zero
        if (horizontalInput != 0.0f && playerMovement != null)
        {
           Vector2 direction = new Vector2(horizontalInput, 0.0f);
           playerMovement.Move(direction);
        }


        // Player Jump

        if (Input.GetButtonDown("Jump") /*&& IsGrounded()*/)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.linearVelocity.y > 0f)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
              
        }

        // Player flip
       // Flip();

    }


}
