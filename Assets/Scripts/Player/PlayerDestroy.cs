using UnityEngine;


public class PlayerDestroy : MonoBehaviour
{
    [SerializeField] private float damage;
    private void OnTriggerEnter2D(Collider2D other)
    {
        IDamageable obj = other.GetComponent<IDamageable>();

        obj.TakeDamage(damage);
    }
}
