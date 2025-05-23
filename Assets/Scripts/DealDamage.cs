using UnityEngine;

public class DealDamage : MonoBehaviour
{
    [SerializeField]
    private int damage = 1;
    [SerializeField]
    private bool playerOnly = true;
   
    private Collider2D col;

    void Awake()
    {
        col = GetComponent<Collider2D>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (playerOnly && !other.CompareTag("Player")) return;

        if (other.TryGetComponent<IHealth>(out var hp))
        {
            hp.TakeDamage(damage);
        }
    }
}
