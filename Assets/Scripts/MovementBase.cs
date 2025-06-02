using UnityEngine;

public class MovementBase : MonoBehaviour
{
        // horizontalPlayerSpeed indicates how fast we accelerate Horizontally
    [SerializeField]
    private float moveSpeed = 2f;

    // local references
    protected Rigidbody2D rb;


    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void Start()
    {
        // populate rb
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// MovePlayer takes a float representing the raw horizontal input, and applies a lateral force
    /// to rb, based on the provided horizontal input, the acceleration
    /// and the delta time.
    /// </summary>
    /// <param name="horizontalInput">Raw horizontal input value. Expected to be between -1 and 1. 
    /// Number outside this range increase movement speed. A value of 0 is ignored.</param>
    public virtual void Move(Vector2 direction)
    {
        if (direction.sqrMagnitude > 0.001f)
        {
            rb.linearVelocity = new Vector2(direction.x * moveSpeed, rb.linearVelocity.y);
        }
    }
}
