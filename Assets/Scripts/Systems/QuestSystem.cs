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
        [SerializeField] private Button startQuestButton;

        private bool _isStarted;
        private void Start()
        {
            if (questItem != null)
            {
                _isStarted = false;
                
                startQuestButton.onClick.AddListener(StartQuest);
            }
        }


        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                FinishQuest();
                Destroy(potion);
            }
        }

        public void StartQuest()
        {
            _isStarted = true;
            Debug.Log("Quest Started");
        }

        private void FinishQuest()
        {
            questItem.color = completedColor;
        }
    }
}