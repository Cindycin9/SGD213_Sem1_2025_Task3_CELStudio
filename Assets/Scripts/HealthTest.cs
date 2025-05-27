using UnityEngine;

public class HealthTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
