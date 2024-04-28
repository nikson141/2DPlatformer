using System;
using UnityEngine;

namespace Systems
{
    public class InPlayersHand : MonoBehaviour
    {
        private Transform _player;
        [SerializeField] private GameObject shotGun;

        private void Start()
        {
            _player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        public void Use()
        {
            Instantiate(shotGun, _player.position, shotGun.transform.rotation, _player.transform);
            Destroy(gameObject);
        }
    }
}
