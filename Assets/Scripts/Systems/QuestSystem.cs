using System;
using UnityEngine;
using UnityEngine.UI;

namespace Systems
{
    public class QuestSystem : MonoBehaviour
    {
        [SerializeField] private Image questItem;
        [SerializeField] private Color completedColor;
        [SerializeField] private Color activeColor;
        [SerializeField] private GameObject potion;




        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                FinishQuest();
                Destroy(potion);
            }
        }

        private void FinishQuest()
        {
            questItem.color = completedColor;
        }
    }
}