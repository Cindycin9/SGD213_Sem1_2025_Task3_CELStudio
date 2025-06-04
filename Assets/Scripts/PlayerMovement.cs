using UnityEngine;
using System.Collections;
using UnityEditor.ShaderGraph.Internal;

// Handles player movement including jump, double jump, dash, and speed modification
public class PlayerMovement : MovementBase

{
    [SerializeField]
    private float jumpForce = 12f;
    [SerializeField]
    private LayerMask groundLayer;
    [SerializeField]
    private float groundCheckDistance = 1.1f;
    [SerializeField]
    private float speed = 8f;
    private float baseSpeed;

    private bool canDoubleJump = false;
    private bool hasDoubleJump = false;
    // Dash mechanic variables
    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 24f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;
    private float horizontal;

    // Visual effect for dashing
    [SerializeField] private TrailRenderer tr;

    protected override void Start()
    {
        base.Start();
        baseSpeed = speed; //Stores inital speed for resetting after the Speed Boost
    }

    // Handles player input each frame
    private void Update()
    {
        if (isDashing)
        {
            return;
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal != 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = Mathf.Sign(horizontal);
            transform.localScale = scale;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
        }
    }

    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }

        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }

    public void Jump()
    {
        if (IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            canDoubleJump = true;
        }
        else if (hasDoubleJump && canDoubleJump)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            canDoubleJump = false;
        }
    }

    public void EnableDoubleJump(float duration)
    {
        hasDoubleJump = true;
        StartCoroutine(DisableDoubleJumpAfterDelay(duration));
    }

    private IEnumerator DisableDoubleJumpAfterDelay(float duration)
    {
        yield return new WaitForSeconds(duration);
        hasDoubleJump = false;
    }

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, groundLayer);
        return hit.collider != null;
    }

    public void ModifySpeed(float multiplier)
    {
        speed = baseSpeed * multiplier;
    }
   
    // Dash coroutine (ngl i still kinda dont know what coroutine means) to move quickly in a direction

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.linearVelocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
}