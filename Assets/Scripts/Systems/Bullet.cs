using System.Collections;
using Player;
using UnityEngine;

namespace Systems
{
    public class Bullet : MonoBehaviour
    {
        [Header("Prefab References")]
        [SerializeField] private float speed = 10f;
        [SerializeField] private Rigidbody2D rb;

        private DamageSystem _damageSystem;
        void Start()
        {
            rb.velocity = transform.right * speed;
            StartCoroutine(DeleteBullet());
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                collision.GetComponent<DamageSystem>().DamageTake();
                Destroy(gameObject, 2f);
            }
        }

        IEnumerator DeleteBullet()
        {
            yield return new WaitForSeconds(2);
            Destroy(gameObject);
        }
    }
}