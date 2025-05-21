using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;


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

    }

}
