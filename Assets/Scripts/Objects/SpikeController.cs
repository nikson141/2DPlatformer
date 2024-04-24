using System;
using System.Collections;
using UnityEngine;

public class SpikeController : MonoBehaviour
{
    [SerializeField] private BoxCollider2D box;
    [SerializeField] private GameObject spikes;
    
    private Trigger _triggerZone;

    private void Awake()
    {
        // Load component.
        _triggerZone = GetComponentInChildren<Trigger>();

        spikes.SetActive(false);

        // Subscribe an event
        _triggerZone.OnPlayerTriggerEnter += SpikeOnPlayerEnterTheTrigger;
    }

    private void OnDestroy()
    {
        // Unsubscribe an event
        _triggerZone.OnPlayerTriggerEnter -= SpikeOnPlayerEnterTheTrigger;
    }

    private void SpikeOnPlayerEnterTheTrigger()
    {
        spikes.SetActive(true);
    }
}
