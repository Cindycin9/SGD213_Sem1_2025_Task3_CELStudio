using UnityEngine;

public class CoinCollectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Destroy the coin object 
            Destroy(gameObject);
        }
    }
}
