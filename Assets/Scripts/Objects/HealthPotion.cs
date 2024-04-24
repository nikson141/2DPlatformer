using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private float potion;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerHealth.gameObject.GetComponent<PlayerHealth>();

            playerHealth.PlayerHealthPotion(potion);
        }
    }
}
