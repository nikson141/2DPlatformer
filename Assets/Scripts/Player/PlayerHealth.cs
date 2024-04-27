using Systems;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class PlayerHealth : MonoBehaviour, IDamageable
    {
        [SerializeField] private float maxHealth;
        [SerializeField] private float currentHealth;
        [SerializeField] private Image healthBar;



        private Animator _anim;

        private void Start()
        {
            currentHealth = maxHealth;
            _anim = GetComponent<Animator>();
        }


        public void TakeDamage(float damage)
        {
            currentHealth -= damage;

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                Destroy(gameObject);
                
            }

            float fillAmount = currentHealth / maxHealth;
            healthBar.fillAmount = fillAmount;
            _anim.Play("Hurting");
        }

        public void PlayerHealthPotion(float potion)
        {
            currentHealth += potion;

            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }

            //HealthBar is decreasing when we hurting
            float fillAmount = currentHealth / maxHealth;
            healthBar.fillAmount = fillAmount;
        }
    }

    public interface IDamageable
    {
        public void TakeDamage(float damage);
    }
}