using UnityEngine;

public class PowerupCollectable : MonoBehaviour
{
    [SerializeField]
    private AudioClip pickupSound;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            IPowerup powerup = GetComponent<IPowerup>();
            if (powerup != null)
            {
                powerup.Activate(other.gameObject);

                //Player pickup sound
                if (pickupSound != null )
                {
                    AudioSource.PlayClipAtPoint(pickupSound, transform.position);
                }

                Destroy(gameObject); //Remove pickup
            }
        }
    }
}
