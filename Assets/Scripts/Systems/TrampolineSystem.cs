using System;
using System.Collections;
using UnityEngine;

namespace Systems
{
    public class TrampolineSystem : MonoBehaviour
    {
        [SerializeField] private float bounce;


        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
            }
        }
    }
}
