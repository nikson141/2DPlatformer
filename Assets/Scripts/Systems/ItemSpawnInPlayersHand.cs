using System;
using Unity.Mathematics;
using UnityEngine;

namespace Systems
{
    public class ItemSpawnInPlayersHand : MonoBehaviour
    {
        [SerializeField] private GameObject item;
        [SerializeField] private GameObject player;

        private void Start()
        {
            item.SetActive(false);
        }

        public void InPlayersHand()
        {
            item.SetActive(true);
        }
    }
}