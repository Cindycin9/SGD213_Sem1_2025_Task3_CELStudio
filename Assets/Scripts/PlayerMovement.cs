using UnityEngine;

public class PlayerMovement : MovementBase
{
    // For now nothing needs to be overriden. 
    // If player needs additional movement types that the enemy does not require, they will override the Move() function here. 





    private Rigidbody2D rb;
 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move()
    {

    }

    public void Jump()
    {

    }

    public void Sprint()
    {

    }


    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }

    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }


}