using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Controls a checkpoint that sets the player's new respawn location
public class CheckPoint : MonoBehaviour
    {
    // Reference to the PlayerRespawn script on the Player
        private PlayerRespawn playerRespawn;
    // Visual indicators for inactive (red) and active (green) checkpoints
        public GameObject greenPoint;
        public GameObject redPoint;


        void Start()
        {
            playerRespawn = GameObject.Find("Player").GetComponent<PlayerRespawn>();
        }
    // Triggers Checkpoint updating new respawn location and changing colour from green too red
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.name == "Player")
            {
                playerRespawn.respawnPoint = transform.position;
                redPoint.SetActive(false);
                greenPoint.SetActive(true);
            }
        }
    }