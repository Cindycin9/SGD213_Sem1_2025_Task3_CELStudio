using UnityEngine;

public class HealthTest : MonoBehaviour
{
    // Triggers Respawn if Player Health = 0
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
    
        
    }
}
