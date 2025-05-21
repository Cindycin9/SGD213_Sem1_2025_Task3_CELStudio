using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;


    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }
    /*

    private void Update()
    {

        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f)
        {

            if (playerMovement != null)
            {
                PlayerMovement.HorizontalMovement(HorizontalInput);
            }
        }

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce = new Vector2(rb.velocity.x, jumpSpeed);
        }

    }*/

    void Update()
    {
        // read our horizontal input axis
        float horizontalInput = Input.GetAxis("Horizontal");

        // if movement input is not zero
        if (horizontalInput != 0.0f)
        {
            // ensure our playerMovement is populated to avoid errors
            if (playerMovement != null)
            {
                // pass our movement input to our playerMovement
                playerMovement.MovePlayer(horizontalInput * Vector2.right);
            }

        }

    }

}
