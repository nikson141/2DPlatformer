using System;
using UnityEngine;

namespace Objects
{
    public class Trigger : MonoBehaviour
    {
        public event Action OnPlayerTriggerEnter;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                OnPlayerTriggerEnter?.Invoke();
            }
        }
    }
}
