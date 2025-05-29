using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int CurrentHealth;
    public int MaxHealth;

    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] hearts;

    public PlayerHealth playerHealth;

    void Start()
    {

    }

    // Updates the Heart Sprites to match the players Current Health
    void Update()
    {
        CurrentHealth = playerHealth.CurrentHealth;
        MaxHealth = playerHealth.MaxHealth;

        // Determines the length(number) of the Sprites
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < MaxHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }
}