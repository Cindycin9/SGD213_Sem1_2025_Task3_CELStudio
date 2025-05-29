using UnityEngine;

public class EnemyStompTrigger : MonoBehaviour
{
    [SerializeField]
    private DealDamage dealDamage;
    [SerializeField]
    private float bounceForce = 10f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        Rigidbody2D playerRb = other.attachedRigidbody;
        if (playerRb.linearVelocity.y < 0 && playerRb.transform.position.y > transform.position.y) // Fall check 
        {
            // Deal damage to enemy 
            dealDamage.GetComponent<IHealth>()?.TakeDamage(999);

            // Player bounce 
            playerRb.linearVelocity = new Vector2(playerRb.linearVelocity.x, bounceForce);
        }
    }
}
