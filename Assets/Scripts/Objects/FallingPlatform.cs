using System;
using System.Collections;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    [SerializeField] private float timeUntilFall;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("Fall", timeUntilFall);
        }
    }

    public void Fall()
    {
        if (gameObject.GetComponent<Rigidbody2D>() != null)
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
