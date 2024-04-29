using System;
using UnityEngine;
using UnityEngine.UI;

namespace Systems
{
    public class SoundSystem : MonoBehaviour
    {
        [SerializeField] private AudioSource bgAudio;
        [SerializeField] private Slider soundSlider;

        private void Start()
        {
            soundSlider.value = bgAudio.volume;
            
            soundSlider.onValueChanged.AddListener(HandSliderValueChanged);
        }

        public void HandSliderValueChanged(float value)
        {
            bgAudio.volume = value;
        }
    }
}