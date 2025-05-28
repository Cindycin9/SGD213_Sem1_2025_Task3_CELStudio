using UnityEngine;

public class HealthTest : MonoBehaviour
<<<<<<< HEAD
{
    // Triggers Respawn if Player Health = 0
=======
{/*
    // Start is called once before the first execution of Update after the MonoBehaviour is created
>>>>>>> 83a4a5e2a07b04e779d054901d3ac4cc8ed89e42
    public int health;
    private PlayerRespawn playerRespawn;
    
    private void Start()
    {
        playerRespawn = GameObject.Find("Player").GetComponent<PlayerRespawn>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(health <= 0)
        {
            playerRespawn.RespawnNow();
            
        }
    
        
<<<<<<< HEAD
    }
   
  
=======
    }
>>>>>>> 83a4a5e2a07b04e779d054901d3ac4cc8ed89e42
}
