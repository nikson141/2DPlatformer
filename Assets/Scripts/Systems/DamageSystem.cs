using System;
using Player;
using UnityEngine;

namespace Systems
{
    public class DamageSystem : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private GameObject enemy;
        [SerializeField] private int maxHealth;
        
        private int _currentHealth;
            
        void Start()
        {
            _currentHealth = maxHealth;
        }

        public void DamageTake()
        {
            _currentHealth --;
            if(_currentHealth <= 0)
            {
                Die();
            }
        }

        public void Die()
        {
            gameObject.SetActive(false);
        } 
    }
}