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

            // Increase the coin count in the UI
            GameManagerScript.Instance.AddCoin();

            // Destroy the coin object 
            Destroy(gameObject);
        }
    }
}
