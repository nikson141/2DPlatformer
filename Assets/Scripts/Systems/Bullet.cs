using System;
using Player;
using Unity.VisualScripting;
using UnityEngine;

namespace Systems
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float bulletLife;

        private void Awake()
        {
            Destroy(gameObject, bulletLife);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                gameObject.SetActive(false);
            }
        }
    }
}