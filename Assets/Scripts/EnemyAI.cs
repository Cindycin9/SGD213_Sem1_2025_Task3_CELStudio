using UnityEditor.Tilemaps;
using UnityEngine;

public class EnemyAI : MovementBase
{
    [SerializeField] 
    private float moveDirection = -1f;
    [SerializeField]
    private Transform groundCheck;
    [SerializeField]
    private LayerMask groundLayer;
    [SerializeField]
    private float groundCheckDistance = 0.1f;

    protected override void Start()
    {
        base.Start(); // Call from MovementBase Start()
    }

    private void FixedUpdate()
    {
        // Move forward
        Move(Vector2.right *  moveDirection);

        // If no ground ahead, turn around
        if (!IsGroundAhead())
        {
            Flip();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (ContactPoint2D contact in collision.contacts)
        {
            if (Mathf.Abs(contact.normal.x) > 0.5f)
            {
                Flip();
                break;
            }
        }
    }

    private bool IsGroundAhead()
    {
        return Physics2D.Raycast(groundCheck.position, Vector2.down, groundCheckDistance, groundLayer);
    }

    private void Flip()
    {
        moveDirection *= -1f;

        Vector3 newScale = transform.localScale;
        newScale.x *= -1f;
        transform.localScale = newScale;
    }

    private void OnDrawGizmos()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(groundCheck.position, groundCheck.position + Vector3.down * groundCheckDistance);
        }
    }

}
