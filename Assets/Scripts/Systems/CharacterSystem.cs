using System.Collections;
using TMPro;
using UnityEngine;
namespace Systems
{
    public class CharacterSystem : MonoBehaviour
    {
        [SerializeField] private GameObject dialogUI;
        [SerializeField] private TextMeshProUGUI dialogueText;
        [SerializeField] private string[] texts;
        [SerializeField] private float dialogueDelay;

        private int _textIndex;
        private bool _canChangeText;

        private void Start()
        {
            dialogUI.SetActive(false);

            _textIndex = 0;
            _canChangeText = false; 
        }

        private void Update()
        {
            SwitchDialogueDisplay(_canChangeText);
            
            if (_canChangeText && _textIndex <= texts.Length)
            {
                StartCoroutine(DialogRoutine());
            }
            
            //Debug.Log(_textIndex);
        }

        private IEnumerator DialogRoutine()
        {
            foreach (var t in texts)
            {
                dialogueText.text = t;
                yield return new WaitForSeconds(dialogueDelay);
                _textIndex++;
            }

            /*ChangeText(_textIndex);

            yield return new WaitForSeconds(dialogueDelay);

            if (_textIndex < texts.Length)
            {
                _textIndex++;
            }*/
        }

        private void ChangeText(int index)
        {
            dialogueText.text = texts[index];
        }
        
        private void SwitchDialogueDisplay(bool obj)
        {
            dialogUI.SetActive(obj);
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            _canChangeText = other.gameObject.CompareTag("Player");
        }
        
        /*private void OnTriggerExit2D(Collider2D other)
        {
            _canChangeText = !other.gameObject.CompareTag("Player");
        }*/
    }
}