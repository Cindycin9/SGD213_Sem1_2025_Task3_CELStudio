using UnityEngine;

public class MovementBase : MonoBehaviour
{


    // horizontalPlayerSpeed indicates how fast we accelerate Horizontally
    [SerializeField]
    private float HorizontalPlayerAcceleration = 5000f;

    // local references
    private Rigidbody2D OURRigidbody;

    void Start()
    {
        // populate ourRigidbody
        OURRigidbody = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// MovePlayer takes a float representing the raw horizontal input, and applies a lateral force
    /// to ourRigidbody, based on the provided horizontal input, the HorizontalPlayerAcceleration
    /// and the delta time.
    /// </summary>
    /// <param name="horizontalInput">Raw horizontal input value. Expected to be between -1 and 1. 
    /// Number outside this range increase movement speed. A value of 0 is ignored.</param>
    public void MovePlayer(float horizontalInput)
    {
        // a horizontalInput of 0 has no effect, as we want our ship to drift
        if (horizontalInput != 0)
        {
            //calculate our force to add
            Vector2 forceToAdd = Vector2.right * horizontalInput * HorizontalPlayerAcceleration * Time.deltaTime;
            // apply forceToAdd to ourRigidbody
            OURRigidbody.AddForce(forceToAdd);
        }
    }

    public void MovePlayer(Vector2 direction)
    {
        // a horizontalInput of 0 has no effect, as we want our ship to drift
        if (direction.magnitude != 0)
        {
            //calculate our force to add
            Vector2 forceToAdd = direction * HorizontalPlayerAcceleration * Time.deltaTime;
            // apply forceToAdd to ourRigidbody
            OURRigidbody.AddForce(forceToAdd);
        }
    }

    //From player movement script

    // Horizontal Axis of the player
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f)
        {
            Vector2 ForceToAdd = Vector2.right * HorizontalInput * HorizontalPlayerAcceleration * Time.deltaTime;
            OURRigidbody.AddForce(ForceToAdd);
        }
    }


}
