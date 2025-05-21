using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;


    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

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

    }

}
