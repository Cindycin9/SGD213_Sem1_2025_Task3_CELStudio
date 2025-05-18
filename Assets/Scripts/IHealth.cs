using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
    // Get the current health. 
    int CurrentHealth { get; }
    // Get the max health.
    int MaxHealth { get; }

    /// <summary>
    /// TakeDamage handles the functionality for taking damage. 
    /// </summary>
    /// <param name="damageAmount"></param>
    void TakeDamage(int damageAmount);

    /// <summary>
    /// Heal handles the functionality for receiving health. 
    /// </summary>
    /// <param name="healingAmount"></param>
    void Heal(int healingAmount);

    /// <summary>
    /// Handles all functionality related to health when health reaches zero. Will also handles any additional death functionality unique to component.
    /// </summary>
    void HandleDeath();
}
