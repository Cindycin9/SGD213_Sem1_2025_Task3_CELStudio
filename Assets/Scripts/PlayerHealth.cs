using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;



public class PlayerHealth : MonoBehaviour, IHealth
{
    public HealthBar healthBar;

    [Header("Health")]
    [SerializeField]
    protected int currentHealth;    
    public int CurrentHealth { get { return currentHealth; } }
    [SerializeField]
    protected int maxHealth;    
    public int MaxHealth { get {return maxHealth; } }
    private PlayerRespawn playerRespawn;
    

    [Header("Invincibility")]
    [SerializeField]
    private float invincibleTime = 1f; // Time in seconds. 
    [SerializeField]
    private float flashSpeed = 10f; // How fast the sprite blinks. 

    private bool isInvincible;
    private SpriteRenderer[] sprites;

    private void Awake()
    {
        // 
        playerRespawn = GetComponent<PlayerRespawn>();
        currentHealth = maxHealth;

        // Get every SpriteRenderer once
        sprites = GetComponentsInChildren<SpriteRenderer>();

        // Add something here to set up health bar on game start. 
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damageAmount)
    {
        if (isInvincible) return; 

        Debug.Log("Player took damage: " + damageAmount);
        currentHealth -= damageAmount;

        // Add something here to update the UI health bar.

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            HandleDeath();
        }
        else
        {
            StartCoroutine(InvincibleRoutine());
        }

        healthBar.SetHealth(currentHealth);

    }

    public void Heal(int healingAmount)
    {
        Debug.Log("Player received health: " + healingAmount);
        currentHealth += healingAmount;

        // Prevent overhealing.
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        // Add something here to update the UI health bar. 
    }

    public void ResetHealth()
    {
        currentHealth = maxHealth;
    }

    public void HandleDeath()
    {
        
        Debug.Log("Player died.");
        playerRespawn.RespawnNow();
        ResetHealth();
        
        // Change functionality when player movement is included. 
    }

    #region Invincibility & Flash

    private System.Collections.IEnumerator InvincibleRoutine()
    {
        isInvincible = true;

        float elapsed = 0f;
        while (elapsed < invincibleTime)
        {
            float alpha = Mathf.Abs(Mathf.Sin(elapsed * flashSpeed));
            foreach (var sr in sprites)
            {
                var c = sr.color;
                c.a = alpha;
                sr.color = c;   
            }
            elapsed += Time.deltaTime;
            yield return null;
        }

        //Ensure sprite is fully visible at the end. 
        foreach (var sr in sprites)
        {
            var c = sr.color;
            c.a = 1f;
            sr.color = c;
        }
        isInvincible = false;
    }
    #endregion

}
