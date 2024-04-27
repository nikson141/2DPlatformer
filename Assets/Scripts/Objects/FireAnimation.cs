using System;
using UnityEngine;

namespace Objects
{
    public class FireAnimation : MonoBehaviour
    {
        [SerializeField] private GameObject player;
        [SerializeField] private Animator anim;

        private void Start()
        {
            anim = GetComponent<Animator>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                anim.Play("Fire");
            }
        }
    }
}