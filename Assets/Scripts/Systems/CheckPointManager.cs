using System;
using UnityEngine;

namespace Systems
{
    public class CheckPointManager : MonoBehaviour
    {
        private RespawnSystem _respawnSystem;
        private BoxCollider2D _boxCollider2D;


        private void Awake()
        {
            _respawnSystem = GameObject.FindGameObjectWithTag("Respawn").GetComponent<RespawnSystem>();
            _boxCollider2D = GetComponent<BoxCollider2D>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _respawnSystem.checkPointPosition = this.gameObject;
                _boxCollider2D.enabled = false;
            }
        }
    }
}