using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Systems
{
    public class MenuSystem : MonoBehaviour
    {
        [SerializeField] private GameObject startButton;
        [SerializeField] private GameObject optionsButton;
        [SerializeField] private GameObject exitButton;
        [SerializeField] private GameObject menuUI;
        [SerializeField] private GameObject backButton;
        [SerializeField] private GameObject optionsUI;

        public void StartButton()
        {
            SceneManager.LoadScene("SampleScene");
            Debug.Log("Scene Loaded");
        }

        private void Start()
        {
            optionsUI.SetActive(false);
        }

        public void OptionsButton()
        {
            menuUI.SetActive(false);
            optionsUI.SetActive(true);
        }

        public void Back()
        {
            menuUI.SetActive(true);
            optionsUI.SetActive(false);
        }

        public void ExitButton()
        {
            Application.Quit();
            Debug.Log("Game Is Closed");
        }
    }
}