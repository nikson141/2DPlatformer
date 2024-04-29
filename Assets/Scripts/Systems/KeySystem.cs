using System;
using UnityEngine;

namespace Systems
{
    public class KeySystem : MonoBehaviour
    {
        [SerializeField] private GameObject door;
        [SerializeField] private Animator anim;


        private void Start()
        {
            anim = GetComponent<Animator>();
        }

        private void Update()
        {
            UseDoor();
        }

        private void UseDoor()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.Play("Door Open");
            }
        }
    }
}