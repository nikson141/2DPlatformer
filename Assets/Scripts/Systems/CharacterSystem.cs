using System;
using UnityEngine;
using UnityEngine.UI;

namespace Systems
{
    public class CharacterSystem : MonoBehaviour
    {
        [SerializeField] private GameObject dialogUI;
        [SerializeField] private GameObject text1;
        //[SerializeField] private GameObject text2;
        //[SerializeField] private GameObject text3;

        private void Start()
        {
            dialogUI.SetActive(false);
            text1.SetActive(false);
            //text2.SetActive(false);
            //text3.SetActive(false);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                dialogUI.SetActive(true);
                text1.SetActive(true);
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                dialogUI.SetActive(false);
                text1.SetActive(false);
            }
        }
    }
}