using System;
using Player;
using UnityEngine;

namespace Systems
{
    public class RespawnSystem : MonoBehaviour
    {
        public GameObject player;
        public GameObject checkPointPosition;
        

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                player.transform.position = checkPointPosition.transform.position;
                Debug.Log("Player Respawned");
            }
        }
    }
}