using UnityEngine;

public class Slot : MonoBehaviour
{
    private InventorySystem inventorySystem;
    public int i;

    private void Start()
    {
        inventorySystem = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    }


    private void Update()
    {
        if (transform.childCount <= 0)
        {
            inventorySystem.isFull[i] = false;
        }
    }


    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<SpawnSystem>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);
        }
    }
}
