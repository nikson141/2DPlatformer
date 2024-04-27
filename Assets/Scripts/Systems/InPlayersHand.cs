using Systems;
using UnityEngine;

public class InPlayersHand : MonoBehaviour
{
    [SerializeField] private GameObject shotgun;

    private InventorySystem inventorySystem;
    public int i;

    private void Start()
    {
        shotgun.SetActive(false);
        inventorySystem = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    }

    private void Update()
    {
        if (transform.childCount <= 0)
        {
            inventorySystem.isFull[i] = false;
        }
    }

    public void ShotGunInPlayersHand()
    {
        shotgun.SetActive(true);
    }
}
