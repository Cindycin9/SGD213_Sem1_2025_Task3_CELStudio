using UnityEngine;

public class MovementBase : MonoBehaviour
{

    // horizontalPlayerSpeed indicates how fast we accelerate Horizontally
    [SerializeField]
    private float HorizontalAcceleration = 5000f;

    // local references
    private Rigidbody2D rb;


    void Start()
    {
        // populate ourRigidbody
        rb = GetComponent<Rigidbody2D>();
    }


    public void Accelerate(Vector2 direction)
    {
        Vector2 forceToAdd = direction * HorizontalAcceleration * Time.deltaTime;

        rb.AddForce(forceToAdd);
    }

    public void MovePlayer(float horizontalInput)
    {
        // a horizontalInput of 0 has no effect, as we want our ship to drift
        if (horizontalInput != 0)
        {
            //calculate our force to add
            Vector2 forceToAdd = Vector2.right * horizontalInput * HorizontalAcceleration * Time.deltaTime;
            // apply forceToAdd to ourRigidbody
            rb.AddForce(forceToAdd);
        }
    }

    public void MovePlayer(Vector2 direction)
    {
        // a horizontalInput of 0 has no effect, as we want our ship to drift
        if (direction.magnitude != 0)
        {
            //calculate our force to add
            Vector2 forceToAdd = direction * HorizontalAcceleration * Time.deltaTime;
            // apply forceToAdd to ourRigidbody
            rb.AddForce(forceToAdd);
        }
    }


}
