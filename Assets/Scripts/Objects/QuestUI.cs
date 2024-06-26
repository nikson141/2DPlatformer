using System;
using UnityEngine;
using UnityEngine.UI;

namespace Objects
{
    public class QuestUI : MonoBehaviour
    {
        [SerializeField] private GameObject questUI;
        
        private void Start()
        {
            questUI.SetActive(false);
        }

        public void OpenQuestUIMenu()
        {
            questUI.SetActive(!questUI.activeSelf);
        }
    }
}