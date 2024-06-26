using UnityEngine;

namespace Systems
{
    public class Slot : MonoBehaviour
    {
        [SerializeField] private InventorySystem inventorySystem;
        public int i;
        [SerializeField] private SpawnSystem spawnSystem;


        private void Start()
        {
            //inventorySystem = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
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
            // This loop is for to drop item and spawn 
            foreach (Transform child in transform)
            {
                spawnSystem.SpawnDroppedItem();
                GameObject.Destroy(child.gameObject);
            }
        }
    }
}
