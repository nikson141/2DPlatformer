using System;
using UnityEngine;

namespace Systems
{
    public class InPlayersHand : MonoBehaviour
    {
        [SerializeField] private GameObject shotgun;
        [SerializeField] private GameObject shotgunInHand;

        private void Start()
        {
            shotgunInHand.SetActive(false);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                shotgun.SetActive(false);
                shotgunInHand.SetActive(true);
            }
        }
    }
}
