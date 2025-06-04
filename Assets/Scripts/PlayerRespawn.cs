using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Lets Respawn position be changed by checkpoints
public class PlayerRespawn : MonoBehaviour
{
    public Vector3 respawnPoint;

    public void RespawnNow()

    {
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