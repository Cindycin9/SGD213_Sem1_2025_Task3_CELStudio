using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Lets Respawn position be updated by checkpoints
public class PlayerRespawn : MonoBehaviour
{
    // Stores the position the player should respawn at
    public Vector3 respawnPoint;

    public void RespawnNow()

    {
        // Moves the player to the stored respawn position
        transform.position = respawnPoint;
    }
    //"death" is placeholder for falling in void
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Death")
        {
            RespawnNow();
        }
        
        // Player respawns if they fall off the map
        if (transform.position.y < -1.5)
        {
            RespawnNow();
            Debug.Log("Player fell off the map!");
        }
    }
}