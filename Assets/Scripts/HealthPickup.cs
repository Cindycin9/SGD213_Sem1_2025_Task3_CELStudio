using UnityEditor.Rendering;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    [SerializeField]
    private int healingAmount = 1;
    [SerializeField]
    private AudioClip pickupSound; // To add a pickup sound.

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        IHealth targetHealth = other.GetComponent<IHealth>();
        if (targetHealth == null ||
            targetHealth.CurrentHealth >= targetHealth.MaxHealth) return;

        targetHealth.Heal(healingAmount);
        Destroy(gameObject); //Remove the pickup after collection. 
    }
}
