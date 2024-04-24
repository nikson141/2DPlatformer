using System;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public event Action OnPlayerTriggerEnter;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnPlayerTriggerEnter?.Invoke();
        }
    }
}
