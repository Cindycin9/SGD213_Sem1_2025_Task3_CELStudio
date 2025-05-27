using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
    {
        private PlayerRespawn playerRespawn;
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