using System;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    public event Action OnPlayerTouchesPlatform;
    private void OnTriggerEnter2D(Collider2D other)
    {
        OnPlayerTouchesPlatform?.Invoke();
    }
}
