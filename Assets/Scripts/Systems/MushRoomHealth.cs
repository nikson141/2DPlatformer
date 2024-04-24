using UnityEngine;

public class MushRoomHealth : MonoBehaviour
{
    private PlayerHealth playerHealth;
    public GameObject healthEffect;
    private float potion = 30f;

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
