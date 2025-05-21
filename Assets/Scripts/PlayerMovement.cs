using UnityEngine;

public class PlayerMovement : MonoBehaviour
{/*
    //
    public float horizontalPlayerAcceleration = 5000f;

    //
    public float Jumpspeed = 8f;

    //
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }  

    */
    
    // Showing private Variable value on Inspector for acceleration, RigidBody2D and Score
    [SerializeField]
    private float acceleration = 75f;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Move(Vector2 direction)
    {
        rb.linearVelocity = direction * acceleration;
    }


}
