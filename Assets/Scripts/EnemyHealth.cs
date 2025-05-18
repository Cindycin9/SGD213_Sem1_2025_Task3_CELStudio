using UnityEngine;

public class EnemyHealth : MonoBehaviour, IHealth
{
    [SerializeField]
    protected int currentHealth;
    public int CurrentHealth { get { return currentHealth; } }

    [SerializeField] 
    protected int maxHealth;
    public int MaxHealth { get { return maxHealth; } }
 
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void Heal(int healingAmount)
    {
        // The enemy does not need to heal, so no logic is required. 
    }

    public void TakeDamage(int damageAmount)
    {
        Debug.Log(gameObject.name + "took damage" + damageAmount);
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            HandleDeath();
        }
    }

    public void HandleDeath()
    {
        Debug.Log(gameObject.name + "died");
        Destroy(gameObject);
    }
 
}
