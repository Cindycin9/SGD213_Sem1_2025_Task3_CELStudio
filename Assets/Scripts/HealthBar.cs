using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    public HealthBar healthBar;

    private PlayerHealth playerHealth;

    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    int health;




    void Start()
    {
        UpdateHearts();
        playerHealth = GetComponent<PlayerHealth>();
        Debug.Log("Stupid start");

    }
    
    void Update()
    {
        UpdateHearts();
    }

    public void UpdateHearts()
    {
        //int health = playerHealth.CurrentHealth;


        for (int i = 0; i < hearts.Length; i++)
        {
            Debug.Log("Stupid");
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].enabled = false;
            }
           
        }

    }
}
