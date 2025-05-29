using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;

    //[SerializedField] private Transform groundCheck;
    //[SerializedField] private LayerMask groundLayer;
    //private bool isFacingRight = true;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }
  
    private void Update()
    {
        // read our horizontal input axis
        float horizontalInput = Input.GetAxis("Horizontal");

        if (playerMovement != null)
        {
            playerMovement.Move(horizontalInput * Vector2.right);
            if (Input.GetButtonDown("Jump"))
            {
                playerMovement.Jump();
            }
        }
    }
}
