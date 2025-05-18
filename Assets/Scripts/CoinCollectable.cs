using UnityEngine;

public class CoinCollectable : MonoBehaviour
{
    [SerializeField]
    private AudioClip pickupSound; // To add a pickup sound.

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (pickupSound)
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);

            // Destroy the coin object 
            Destroy(gameObject);
        }
    }
}
