using UnityEngine;

public class PlayerMovement : MovementBase
{
    [SerializeField]
    private float jumpForce = 12f;
    [SerializeField]
    private LayerMask groundLayer;
    [SerializeField]
    private float groundCheckDistance = 1.1f;

    protected override void Start()
    {
        base.Start(); //from MovementBase
    }
        
    public void Jump()
    {
        if (IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    public void Sprint()
    {

    }


   /*private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }

    }*/

    private bool IsGrounded()
    {
       RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, groundLayer);
        return hit.collider != null;
    }
    

}