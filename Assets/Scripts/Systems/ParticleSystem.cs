using System;
using UnityEngine;

namespace Systems
{
    public class ParticleSystem : MonoBehaviour
    {
        [SerializeField] private UnityEngine.ParticleSystem movementParticle;

        [Range(0, 10)] [SerializeField] private int occurAfterVelocity;

        [Range(0, 0.2f)] [SerializeField] private float dustFormationPeriod;

        [SerializeField] private Rigidbody2D rb;

        private float _counter;

        private void Update()
        {
            _counter += Time.deltaTime;

            if (Mathf.Abs(rb.velocity.x) > occurAfterVelocity)
            {
                if (_counter > dustFormationPeriod)
                {
                    movementParticle.Play();
                    _counter = 0;
                }
            }
        }
    }
}