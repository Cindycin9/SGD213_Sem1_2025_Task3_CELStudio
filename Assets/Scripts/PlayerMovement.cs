using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
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

}
