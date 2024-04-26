using UnityEngine;
using UnityEngine.SceneManagement;

namespace Systems
{
    public class MenuSystem : MonoBehaviour
    {
        [SerializeField] private GameObject startButton;
        [SerializeField] private GameObject optionsButton;
        [SerializeField] private GameObject exitButton;

        public void StartButton()
        {
            SceneManager.LoadScene("SampleScene");
            Debug.Log("Scene Loaded");
        }

        public void OptionsButton()
        {
            
        }

        public void ExitButton()
        {
            Application.Quit();
            Debug.Log("Game Is Closed");
        }
    }
}