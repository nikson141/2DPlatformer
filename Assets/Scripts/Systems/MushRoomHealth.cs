using Player;
using UnityEngine;

namespace Systems
{
    public class MushRoomHealth : MonoBehaviour
    {
        [SerializeField] private PlayerHealth playerHealth;
        public GameObject healthEffect;
        [SerializeField] private float potion = 30f;

        private void Start()
        {
            playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        }

        public void Use()
        {
            Instantiate(healthEffect, playerHealth.transform.position, Quaternion.identity);
            playerHealth.PlayerHealthPotion(potion);
            Destroy(gameObject);
        }
    }
}
