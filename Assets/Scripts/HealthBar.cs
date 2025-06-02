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
    
    public void SetHealth(int current, int max)
    {
        Debug.Log($"SetHealth called: current = {current}, max = {max}");
        CurrentHealth = current;
        MaxHealth = max;

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < CurrentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            hearts[i].enabled = i < MaxHealth;
        }
    }
}