using UnityEditor.Rendering;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    [SerializeField]
    private int healingAmount = 1;
    [SerializeField]
    private AudioClip pickupSound; // To add a pickup sound.
    

    private AudioSource audioSource;
    private bool collected = false;

    private void Awake()
    {
        // Add or get an AudioSource on the health collectable.
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null && pickupSound != null )
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.playOnAwake = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (collected || !other.CompareTag("Player")) return;

        IHealth targetHealth = other.GetComponent<IHealth>();
        if (targetHealth == null || targetHealth.CurrentHealth >= targetHealth.MaxHealth) return;

        targetHealth.Heal(healingAmount);
        collected = true;

        //Play sound if assigned.
        if (pickupSound != null && audioSource != null)
        {
            audioSource.clip = pickupSound;
            audioSource.Play();
            Destroy(gameObject, pickupSound.length);
        }
        else
        {
            Destroy(gameObject); //Remove the pickup after collection. 
        }  
    }
}
