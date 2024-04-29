using Systems;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class WeaponPickUpSystem : MonoBehaviour
{
    private InventorySystem inventorySystem;

    public GameObject itemButton;

    private void Start()
    {
        inventorySystem = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // This Makes When Slot is full player can't take more items
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventorySystem.slots.Length; i++)
            {
                if (inventorySystem.isFull[i] == false)
                {
                    inventorySystem.isFull[i] = true;
                    Instantiate(itemButton, inventorySystem.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
