using System;
using UnityEngine;


namespace Systems
{
    public class ShootingSystem : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform spawnPosition;
        [SerializeField] private float bulletSpeed;

        private void Update()
        {
            if (Input.GetMouseButton(1))
            {
                ShootingFromWeapon();
            }
        }

        private void ShootingFromWeapon()
        {
            Instantiate(bulletPrefab, spawnPosition.position, Quaternion.identity);
        }
    }
}
